using OrderHub.Server.Interfaces;
using OrderHub.Server.Data;
using OrderHub.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace OrderHub.Server.Services
{
    public class OrderService : IOrder
    {
        readonly OrderDbContext _dbContext = new();
        public OrderService(OrderDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        //To Get all Order details
        public List<Order> GetOrderDetails()
        {
            try
            {
                return _dbContext.Orders.ToList();
            }
            catch
            {
                throw;
            }
        }
        //To Add new order record
        public void AddOrder(Order order)
        {
            try
            {
                _dbContext.Orders.Add(order);
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        
        //To Update the records of a particluar order
        public void UpdateOrderDetails(Order order)
        {
            try
            {
                _dbContext.Entry(order).State = EntityState.Modified;
                _dbContext.SaveChanges();
            }
            catch
            {
                throw;
            }
        }
        //Get the details of a particular order
        public Order GetOrderData(int id)
        {
            try
            {
                Order? order = _dbContext.Orders.Find(id);
                if (order != null)
                {
                    return order;
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
        //To Delete the record of a particular order
        public void DeleteOrder(int id)
        {
            try
            {
                Order? order = _dbContext.Orders.Find(id);
                if (order != null)
                {
                    _dbContext.Orders.Remove(order);
                    _dbContext.SaveChanges();
                }
                else
                {
                    throw new ArgumentNullException();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}