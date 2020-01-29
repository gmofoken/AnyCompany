namespace AnyCompany
{
    public class OrderService
    {
        private readonly OrderRepository orderRepository = new OrderRepository();

        public bool PlaceOrder(Order order, int customerId)
        {
            Customer customer = CustomerRepository.Load(customerId);

            if (order.Amount == 0)
                return false;

            if (customer.Country == "UK")
                order.VAT = 0.2d;
            else
                order.VAT = 0;

            orderRepository.Save(order, customerId);

            return true;
        }

        public Order LoadOrder(int CustomerId)
        {
            Order order = new Order();
            return orderRepository.Load(CustomerId);
        }
    }
}
