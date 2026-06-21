using Microsoft.AspNetCore.Mvc;
using SalesMS.BLL.Services;
using SalesMS.DAL.Entities;

namespace SalesMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrderService _orderService;

        public OrderController(OrderService orderService)
        {
            _orderService = orderService;
        }

        // GET: api/order
        [HttpGet]
        public IActionResult GetAll()
        {
            var orders = _orderService.GetAllOrders().ToList();
            return Ok(orders);
        }

        // GET: api/order/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var order = _orderService.GetOrderById(id);

            if (order == null)
                return NotFound();

            return Ok(order);
        }

        // POST: api/order
        [HttpPost]
        public IActionResult Create(Order order)
        {
            var result = _orderService.AddOrder(order);

            if (!result)
                return BadRequest("Invalid customer");

            return Ok(order);
        }

        // GET: api/order/customer/3
        [HttpGet("customer/{customerId}")]
        public IActionResult GetByCustomer(int customerId)
        {
            var orders = _orderService.GetOrdersByCustomerId(customerId);
            return Ok(orders);
        }

        // GET: api/order/between?from=2024-01-01&to=2024-12-31
        [HttpGet("between")]
        public IActionResult GetBetween(DateTime from, DateTime to)
        {
            var orders = _orderService.GetOrdersBetween(from, to).ToList();
            return Ok(orders);
        }
    }
}