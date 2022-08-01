using OrderHub.Server.Interfaces;
using OrderHub.Shared.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace OrderHub.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _IOrder;
        public OrderController(IOrder iOrder)
        {
            _IOrder = iOrder;
        }
        [HttpGet]
        public async Task<List<Order>> Get()
        {
            return await Task.FromResult(_IOrder.GetOrderDetails());
        }

        [HttpPost]
        public async void Post(Order order)
        {
            _IOrder.AddOrder(order);
        }
    }
}