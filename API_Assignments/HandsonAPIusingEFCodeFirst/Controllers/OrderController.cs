
using HandsonAPIusingEFCodeFirst.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HandsonAPIusingEFCodeFirst.Entities;

namespace HandsonAPIusingEFCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;

        public OrderController(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        [HttpGet]
        [Route("GetAllOrders/{orderId}")]
        public IActionResult GetAllOrders(Guid orderId)
        {
            var orders = _orderRepository.GetAllOrders(orderId);
            return Ok(orders);
        }

        [HttpGet]
        [Route("GetOrder/{orderId}")]
        public IActionResult GetOrder(Guid orderId)
        {
            var order = _orderRepository.GetOrder(orderId);
            if (order != null)
            {
                return Ok(order);
            }
            return NotFound("Order not found");
        }

        [HttpPost]
        [Route("MakeOrder")]
        public IActionResult MakeOrder(Order order)
        {
            order.OrderID = Guid.NewGuid();
            _orderRepository.MakeOrder(order);
            return StatusCode(201, order);
        }
    }
}
