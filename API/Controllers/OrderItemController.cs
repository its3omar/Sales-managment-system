using Microsoft.AspNetCore.Mvc;
using SalesMS.BLL.Services;

namespace SalesMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrderItemController : ControllerBase
    {
        private readonly OrderItemService _orderItemService;

        public OrderItemController(OrderItemService orderItemService)
        {
            _orderItemService = orderItemService;
        }

        // POST: api/orderitem/add-items
        [HttpPost("add-items")]
        public IActionResult AddItems([FromBody] Dictionary<int, int> cart, int orderId)
        {
            var result = _orderItemService.AddOrderItems(cart, orderId);

            if (!result)
                return BadRequest("Failed to add items");

            return Ok("Items added successfully");
        }

        // GET: api/orderitem/best-selling
        [HttpGet("best-selling")]
        public IActionResult GetBestSelling()
        {
            var products = _orderItemService.GetBestSellingProducts();
            return Ok(products);
        }

        // GET: api/orderitem/total-profit
        [HttpGet("total-profit")]
        public IActionResult GetProfit()
        {
            var profit = _orderItemService.GetTotalProjectPenifit();
            return Ok(profit);
        }
    }
}