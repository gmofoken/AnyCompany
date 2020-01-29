using System.Data.SqlClient;

namespace AnyCompany
{
    internal class OrderRepository
    {
        private static string ConnectionString = @"Data Source=(local);Database=Orders;User Id=admin;Password=password;";

        public void Save(Order order, int CustomerId)
        {
            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("INSERT INTO Orders VALUES (@OrderId, @Amount, @VAT, @CustomerId)", connection);

            command.Parameters.AddWithValue("@OrderId", order.OrderId);
            command.Parameters.AddWithValue("@Amount", order.Amount);
            command.Parameters.AddWithValue("@VAT", order.VAT);
            command.Parameters.AddWithValue("@CustomerId", CustomerId);

            command.ExecuteNonQuery();

            connection.Close();
        }

        public Order Load(int customerId)
        {
            Order order = new Order();

            SqlConnection connection = new SqlConnection(ConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand("SELECT * FROM Orders WHERE CustomerId = " + customerId,
                connection);
            var reader = command.ExecuteReader();

            while (reader.Read())
            {
                order.OrderId = (int)reader["OrderId"];
                order.Amount = double.Parse(reader["Amount"].ToString(), System.Globalization.CultureInfo.InvariantCulture);
                order.VAT = double.Parse(reader["VAT"].ToString(), System.Globalization.CultureInfo.InvariantCulture); ;
            }

            connection.Close();

            return order;
        }
    }

}
