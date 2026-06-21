using Microsoft.AspNetCore.Mvc;
using SalesMS.BLL.Services;
using SalesMS.DAL.Entities;

namespace SalesMS.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        // GET: api/customer
        [HttpGet]
        public IActionResult GetAll()
        {
            var customers = _customerService.GetAllCustemers().ToList();
            return Ok(customers);
        }

        // GET: api/customer/5
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var customer = _customerService.GetCustomerById(id);

            if (customer == null)
                return NotFound();

            return Ok(customer);
        }

        // POST: api/customer
        [HttpPost]
        public IActionResult Create(Customer c)
        {
            var result = _customerService.AddNewCustomer(c);

            if (!result)
                return BadRequest("Invalid customer data");

            return Ok(c);
        }

        // PUT: api/customer/5
        [HttpPut("{id}")]
        public IActionResult Update(int id, Customer updated)
        {
            var result = _customerService.UpdateCustomer(
                id,
                updated.Name,
                updated.Email,
                updated.Phone
            );

            if (!result)
                return BadRequest("Update failed");

            return Ok("Updated successfully");
        }

        // DELETE: api/customer/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var result = _customerService.DeleteCustomer(id);

            if (!result)
                return NotFound();

            return Ok("Deleted successfully");
        }

        // POST: api/customer/deposit
        [HttpPost("deposit")]
        public IActionResult Deposit(int customerId, decimal amount)
        {
            var result = _customerService.Deposit(customerId, amount);

            if (!result)
                return BadRequest("Deposit failed");

            return Ok("Balance updated");
        }

        // POST: api/customer/deduct
        [HttpPost("deduct")]
        public IActionResult Deduct(int customerId, decimal totalPrice)
        {
            var result = _customerService.deductOrderPrice(customerId, totalPrice);

            if (!result)
                return BadRequest("Deduction failed");

            return Ok("Balance deducted");
        }

        // POST: api/customer/login
        [HttpPost("login")]
        public IActionResult Login(string username, string email)
        {
            var customer = _customerService.Login(username, email);

            if (customer == null)
                return Unauthorized();

            return Ok(customer);
        }

        // GET: api/customer/top
        [HttpGet("top")]
        public IActionResult GetTopCustomers()
        {
            var customers = _customerService.GetValuedCustomers();
            return Ok(customers);
        }

        // GET: api/customer/count
        [HttpGet("count")]
        public IActionResult Count()
        {
            var count = _customerService.CountTotalCustomers();
            return Ok(count);
        }
    }
}