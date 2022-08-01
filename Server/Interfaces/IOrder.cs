using OrderHub.Shared.Models;

namespace OrderHub.Server.Interfaces
{
    public interface IOrder
    {
        public List<Order> GetOrderDetails();
        public void AddOrder(Order order);
        public void UpdateOrderDetails(Order order);
        public Order GetOrderData(int id);
        
        public void DeleteOrder(int id);
    }
}