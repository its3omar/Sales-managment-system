using System;

namespace SalesMS.BLL.Services
{
    public class OrderService
    {
        AppDbContext _context;
        public OrderService(AppDbContext context)
        {
            _context = context;
        }
        public Order? GetOrderById(int id)
        {
            return _context.Orders.Find(id);
        }
        public IQueryable<Order> GetAllOrders()
        {
            return _context.Orders;
        }
        public bool AddOrder(Order order)
        {
           bool IsActiveCustomer=_context.Customers.Any(c=>c.Id==order.CustomerId);
            if (!IsActiveCustomer) { return false; }
            
            order.OrderDate = DateTime.Now;
            
                _context.Orders.Add(order);
                return (_context.SaveChanges() > 0);
            
        }
        public List<dynamic> GetOrdersByCustomerId(int customerId)
        {
            return _context.Orders
                .Where(o => o.CustomerId == customerId)
                .Select(o => new
                {
                    Date = o.OrderDate,
                    TotalAmount = o.TotalAmount
                })
                .Cast<dynamic>()
                .ToList();
        }
        public IQueryable<Order> GetOrdersBetween(DateTime FromDate,DateTime ToDate)
        {
            return _context.Orders.Where(o=>o.OrderDate>=FromDate&& o.OrderDate<=ToDate);
        }
        public bool CompletePurshaseOrder(decimal TotalOrderPrice,int customerId)
        {
            decimal customerBalance = _context.Customers.Where(c => c.Id == customerId).Select(c => c.Balance).Single();
            return customerBalance>=TotalOrderPrice;
        }
        public decimal GetOrderPrice(Dictionary<int, int> cart)
        {
            var products = _context.Products
    .Where(p => cart.Keys.Contains(p.Id))
    .ToList();

            decimal totalPrice = products.Sum(p => p.salePrice * cart[p.Id]);
            return totalPrice;
        }
        public decimal calculateTotalSales()
        {
            return _context.Orders.Sum(o => o.TotalAmount);
        }
    }
}
