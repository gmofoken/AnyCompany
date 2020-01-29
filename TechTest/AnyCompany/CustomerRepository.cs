using System;
using System.Data;
using System.Data.SqlClient;

namespace AnyCompany
{
    public static class CustomerRepository
    {
        private static string ConnectionString = @"Data Source=(local);Database=Customers;User Id=admin;Password=password;";

        public static Customer Load(int customerId)
        {
            Customer customer = new Customer();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Customer WHERE CustomerId = " + customerId,
                connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                customer.Name = reader["Name"].ToString();
                customer.DateOfBirth = DateTime.Parse(reader["DateOfBirth"].ToString());
                customer.Country = reader["Country"].ToString();
            }

            connection.Close();

            return customer;
        }

        public static DataTable LoadAll()
        {
            Customer customer = new Customer();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Customer",
                connection);
            var reader = command.ExecuteReader();

            var dataTable = new DataTable();
            dataTable.Load(reader);

            connection.Close();

            return dataTable;
        }

        public static int Save(Customer customer)
        {
            int returnValue = -1;
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Customer(Name, Country, DateOfBirth) OUTPUT INSERTED.CustomerId VALUES (@Name, @Country, @DateOfBirth); SELECT SCOPE_IDENTITY();", connection);

            command.Parameters.AddWithValue("@Name", customer.Name);
            command.Parameters.AddWithValue("@Country", customer.Country);
            command.Parameters.AddWithValue("@DateOfBirth", customer.DateOfBirth);

            object returnObj = command.ExecuteScalar();

            if (returnObj != null)
                int.TryParse(returnObj.ToString(), out returnValue);

            connection.Close();

            return returnValue;
        }
    }
}
