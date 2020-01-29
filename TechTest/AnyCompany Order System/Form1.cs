using AnyCompany;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnyCompany_Order_System
{
    public partial class Form1 : Form
    {
        int customerID = 0;

        public Form1()
        {
            InitializeComponent();
            pnlPlaceOrder.Enabled = false;
            pnlViewOrder.Enabled = false;
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();

            customer.Name = txtBxName.Text;
            customer.Country = txtBxCountry.Text;
            customer.DateOfBirth = dtpDOB.Value;

            try
            {
                customerID = CustomerRepository.Save(customer);
                pnlOrder.Enabled = true;
                pnlCustomer.Enabled = false;
                lblMessage.Text = "Customer details saved";
            }
            catch (Exception)
            {
                lblMessage.Text = "Failed to save customer details";
            }
        }

        private void txtBxAmount_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(txtBxAmount.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                txtBxAmount.Text = txtBxAmount.Text.Remove(txtBxAmount.Text.Length - 1);
            }
        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            Order order = new Order();
            DateTime currentDate = DateTime.Now;
            long elapsedTicks = currentDate.Ticks;
            OrderService orderService = new OrderService();

            order.Amount = (txtBxAmount.Text.Length > 0) ? Convert.ToDouble(txtBxAmount.Text) : 0 ;
            order.OrderId = (int)elapsedTicks;

            try
            {
                orderService.PlaceOrder(order, customerID);
                lblMessage.Text = "Success, order placed!";
            }
            catch (Exception)
            {
                lblMessage.Text = "Failed to place order";
            }
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            Order order = new Order();
            OrderService orderService = new OrderService();
            int customerId = int.Parse(txtCustomerId.Text);

            customer = CustomerRepository.Load(customerId);
            order = orderService.LoadOrder(customerId);

            lblName.Text = "NAME :  " + customer.Name;
            lblCountry.Text = "COUNTRY :  " + customer.Country;
            lblDOB.Text = "DATE OF BIRTH :  " + customer.DateOfBirth.Date.ToString();

            lblOrderId.Text = "ORDER ID : " + order.OrderId;
            lblAmount.Text = "AMOUNT : " + order.Amount;
            lblVAT.Text = "VAT : " + order.VAT + "%";
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            pnlPlaceOrder.Enabled = true;
            pnlViewOrder.Enabled = false;
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            pnlPlaceOrder.Enabled = false;
            pnlViewOrder.Enabled = true;
        }

        private void btnSearchDetails_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = true;
            pnlCustomers.Visible = false;
        }

        private void btnViewCustomers_Click(object sender, EventArgs e)
        {
            pnlSearch.Visible = false;
            pnlCustomers.Visible = true;


            DataTable customers = CustomerRepository.LoadAll();
            dgvCustomers.DataSource = customers;
        }
    }
}
