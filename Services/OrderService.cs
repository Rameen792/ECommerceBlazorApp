using ECommerceBlazorApp.Models;

namespace ECommerceBlazorApp.Services
{
    public class OrderService
    {
        private Order lastOrder;

        public void PlaceOrder(Order order)
        {
            lastOrder = order;
        }

        public Order GetLastOrder()
        {
            return lastOrder;
        }
    }
}
