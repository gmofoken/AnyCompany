namespace AnyCompany_Order_System
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBxName = new System.Windows.Forms.TextBox();
            this.txtBxCountry = new System.Windows.Forms.TextBox();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSaveUser = new System.Windows.Forms.Button();
            this.pnlCustomer = new System.Windows.Forms.Panel();
            this.pnlOrder = new System.Windows.Forms.Panel();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBxAmount = new System.Windows.Forms.TextBox();
            this.lblMessage = new System.Windows.Forms.Label();
            this.pnlPlaceOrder = new System.Windows.Forms.Panel();
            this.pnlViewOrder = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtCustomerId = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblOrderId = new System.Windows.Forms.Label();
            this.lblVAT = new System.Windows.Forms.Label();
            this.lblAmount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnGetOrder = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnViewCustomers = new System.Windows.Forms.Button();
            this.btnSearchDetails = new System.Windows.Forms.Button();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.pnlCustomers = new System.Windows.Forms.Panel();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.pnlCustomer.SuspendLayout();
            this.pnlOrder.SuspendLayout();
            this.pnlPlaceOrder.SuspendLayout();
            this.pnlViewOrder.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlCustomers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBxName
            // 
            this.txtBxName.Location = new System.Drawing.Point(138, 35);
            this.txtBxName.Name = "txtBxName";
            this.txtBxName.Size = new System.Drawing.Size(200, 22);
            this.txtBxName.TabIndex = 0;
            // 
            // txtBxCountry
            // 
            this.txtBxCountry.Location = new System.Drawing.Point(138, 76);
            this.txtBxCountry.Name = "txtBxCountry";
            this.txtBxCountry.Size = new System.Drawing.Size(200, 22);
            this.txtBxCountry.TabIndex = 1;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(138, 113);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(200, 22);
            this.dtpDOB.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "NAME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "COUNTRY";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "DOB";
            // 
            // btnSaveUser
            // 
            this.btnSaveUser.Location = new System.Drawing.Point(138, 156);
            this.btnSaveUser.Name = "btnSaveUser";
            this.btnSaveUser.Size = new System.Drawing.Size(151, 23);
            this.btnSaveUser.TabIndex = 7;
            this.btnSaveUser.Text = "SAVE USER";
            this.btnSaveUser.UseVisualStyleBackColor = true;
            this.btnSaveUser.Click += new System.EventHandler(this.btnSaveUser_Click);
            // 
            // pnlCustomer
            // 
            this.pnlCustomer.Controls.Add(this.txtBxCountry);
            this.pnlCustomer.Controls.Add(this.btnSaveUser);
            this.pnlCustomer.Controls.Add(this.txtBxName);
            this.pnlCustomer.Controls.Add(this.label3);
            this.pnlCustomer.Controls.Add(this.dtpDOB);
            this.pnlCustomer.Controls.Add(this.label2);
            this.pnlCustomer.Controls.Add(this.label1);
            this.pnlCustomer.Location = new System.Drawing.Point(0, 37);
            this.pnlCustomer.Name = "pnlCustomer";
            this.pnlCustomer.Size = new System.Drawing.Size(412, 228);
            this.pnlCustomer.TabIndex = 8;
            // 
            // pnlOrder
            // 
            this.pnlOrder.Controls.Add(this.label7);
            this.pnlOrder.Controls.Add(this.btnPlaceOrder);
            this.pnlOrder.Controls.Add(this.label4);
            this.pnlOrder.Controls.Add(this.txtBxAmount);
            this.pnlOrder.Enabled = false;
            this.pnlOrder.Location = new System.Drawing.Point(3, 271);
            this.pnlOrder.Name = "pnlOrder";
            this.pnlOrder.Size = new System.Drawing.Size(409, 267);
            this.pnlOrder.TabIndex = 9;
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(43, 127);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(234, 51);
            this.btnPlaceOrder.TabIndex = 2;
            this.btnPlaceOrder.Text = "PLACE ORDER";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 1;
            this.label4.Text = "ORDER AMOUNT";
            // 
            // txtBxAmount
            // 
            this.txtBxAmount.Location = new System.Drawing.Point(138, 48);
            this.txtBxAmount.Name = "txtBxAmount";
            this.txtBxAmount.Size = new System.Drawing.Size(166, 22);
            this.txtBxAmount.TabIndex = 0;
            this.txtBxAmount.TextChanged += new System.EventHandler(this.txtBxAmount_TextChanged);
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMessage.Location = new System.Drawing.Point(1, 28);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 36);
            this.lblMessage.TabIndex = 10;
            // 
            // pnlPlaceOrder
            // 
            this.pnlPlaceOrder.Controls.Add(this.label6);
            this.pnlPlaceOrder.Controls.Add(this.lblMessage);
            this.pnlPlaceOrder.Controls.Add(this.pnlOrder);
            this.pnlPlaceOrder.Controls.Add(this.pnlCustomer);
            this.pnlPlaceOrder.Location = new System.Drawing.Point(12, 61);
            this.pnlPlaceOrder.Name = "pnlPlaceOrder";
            this.pnlPlaceOrder.Size = new System.Drawing.Size(415, 541);
            this.pnlPlaceOrder.TabIndex = 11;
            // 
            // pnlViewOrder
            // 
            this.pnlViewOrder.Controls.Add(this.pnlCustomers);
            this.pnlViewOrder.Controls.Add(this.pnlSearch);
            this.pnlViewOrder.Controls.Add(this.btnSearchDetails);
            this.pnlViewOrder.Controls.Add(this.btnViewCustomers);
            this.pnlViewOrder.Location = new System.Drawing.Point(450, 60);
            this.pnlViewOrder.Name = "pnlViewOrder";
            this.pnlViewOrder.Size = new System.Drawing.Size(619, 538);
            this.pnlViewOrder.TabIndex = 12;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(383, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(176, 33);
            this.btnSearch.TabIndex = 0;
            this.btnSearch.Text = "SEARCH ";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtCustomerId
            // 
            this.txtCustomerId.Location = new System.Drawing.Point(155, 37);
            this.txtCustomerId.Name = "txtCustomerId";
            this.txtCustomerId.Size = new System.Drawing.Size(190, 22);
            this.txtCustomerId.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(85, 137);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(0, 17);
            this.lblName.TabIndex = 2;
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Location = new System.Drawing.Point(85, 219);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(0, 17);
            this.lblDOB.TabIndex = 3;
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Location = new System.Drawing.Point(85, 180);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(0, 17);
            this.lblCountry.TabIndex = 4;
            // 
            // lblOrderId
            // 
            this.lblOrderId.AutoSize = true;
            this.lblOrderId.Location = new System.Drawing.Point(85, 258);
            this.lblOrderId.Name = "lblOrderId";
            this.lblOrderId.Size = new System.Drawing.Size(0, 17);
            this.lblOrderId.TabIndex = 5;
            // 
            // lblVAT
            // 
            this.lblVAT.AutoSize = true;
            this.lblVAT.Location = new System.Drawing.Point(85, 320);
            this.lblVAT.Name = "lblVAT";
            this.lblVAT.Size = new System.Drawing.Size(0, 17);
            this.lblVAT.TabIndex = 6;
            // 
            // lblAmount
            // 
            this.lblAmount.AutoSize = true;
            this.lblAmount.Location = new System.Drawing.Point(85, 287);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(0, 17);
            this.lblAmount.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "CUSTOMER ID";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(28, 13);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(264, 34);
            this.btnOrder.TabIndex = 13;
            this.btnOrder.Text = "PLACE ORDER";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnGetOrder
            // 
            this.btnGetOrder.Location = new System.Drawing.Point(450, 13);
            this.btnGetOrder.Name = "btnGetOrder";
            this.btnGetOrder.Size = new System.Drawing.Size(264, 34);
            this.btnGetOrder.TabIndex = 14;
            this.btnGetOrder.Text = "GET ORDER";
            this.btnGetOrder.UseVisualStyleBackColor = true;
            this.btnGetOrder.Click += new System.EventHandler(this.btnGetOrder_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "SAVE CUSTOMER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(96, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "PLACE ORDER";
            // 
            // btnViewCustomers
            // 
            this.btnViewCustomers.Location = new System.Drawing.Point(73, 59);
            this.btnViewCustomers.Name = "btnViewCustomers";
            this.btnViewCustomers.Size = new System.Drawing.Size(158, 23);
            this.btnViewCustomers.TabIndex = 9;
            this.btnViewCustomers.Text = "VIEW CUSTOMERS";
            this.btnViewCustomers.UseVisualStyleBackColor = true;
            this.btnViewCustomers.Click += new System.EventHandler(this.btnViewCustomers_Click);
            // 
            // btnSearchDetails
            // 
            this.btnSearchDetails.Location = new System.Drawing.Point(304, 57);
            this.btnSearchDetails.Name = "btnSearchDetails";
            this.btnSearchDetails.Size = new System.Drawing.Size(263, 23);
            this.btnSearchDetails.TabIndex = 10;
            this.btnSearchDetails.Text = "SEARCH ORDER BY CUSTOMER ID";
            this.btnSearchDetails.UseVisualStyleBackColor = true;
            this.btnSearchDetails.Click += new System.EventHandler(this.btnSearchDetails_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.Controls.Add(this.label5);
            this.pnlSearch.Controls.Add(this.btnSearch);
            this.pnlSearch.Controls.Add(this.txtCustomerId);
            this.pnlSearch.Controls.Add(this.lblAmount);
            this.pnlSearch.Controls.Add(this.lblName);
            this.pnlSearch.Controls.Add(this.lblVAT);
            this.pnlSearch.Controls.Add(this.lblDOB);
            this.pnlSearch.Controls.Add(this.lblOrderId);
            this.pnlSearch.Controls.Add(this.lblCountry);
            this.pnlSearch.Location = new System.Drawing.Point(3, 114);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(613, 421);
            this.pnlSearch.TabIndex = 8;
            this.pnlSearch.Visible = false;
            // 
            // pnlCustomers
            // 
            this.pnlCustomers.Controls.Add(this.dgvCustomers);
            this.pnlCustomers.Location = new System.Drawing.Point(6, 106);
            this.pnlCustomers.Name = "pnlCustomers";
            this.pnlCustomers.Size = new System.Drawing.Size(609, 428);
            this.pnlCustomers.TabIndex = 11;
            this.pnlCustomers.Visible = false;
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Location = new System.Drawing.Point(0, 26);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(609, 401);
            this.dgvCustomers.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1083, 680);
            this.Controls.Add(this.btnGetOrder);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.pnlViewOrder);
            this.Controls.Add(this.pnlPlaceOrder);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlCustomer.ResumeLayout(false);
            this.pnlCustomer.PerformLayout();
            this.pnlOrder.ResumeLayout(false);
            this.pnlOrder.PerformLayout();
            this.pnlPlaceOrder.ResumeLayout(false);
            this.pnlPlaceOrder.PerformLayout();
            this.pnlViewOrder.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlSearch.PerformLayout();
            this.pnlCustomers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtBxName;
        private System.Windows.Forms.TextBox txtBxCountry;
        private System.Windows.Forms.DateTimePicker dtpDOB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSaveUser;
        private System.Windows.Forms.Panel pnlCustomer;
        private System.Windows.Forms.Panel pnlOrder;
        private System.Windows.Forms.TextBox txtBxAmount;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.Panel pnlPlaceOrder;
        private System.Windows.Forms.Panel pnlViewOrder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtCustomerId;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAmount;
        private System.Windows.Forms.Label lblVAT;
        private System.Windows.Forms.Label lblOrderId;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnGetOrder;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Button btnSearchDetails;
        private System.Windows.Forms.Button btnViewCustomers;
        private System.Windows.Forms.Panel pnlCustomers;
        private System.Windows.Forms.DataGridView dgvCustomers;
    }
}

