
using Microsoft.EntityFrameworkCore;

namespace SalesMS.BLL.Services
{
    public class OrderItemService
    {
        private readonly AppDbContext _context;
        public OrderItemService(AppDbContext context)
        {
            _context = context;
        }
        public void AddOrderItem(OrderItem orderItem) {
            if (orderItem == null) { return; }
            if (orderItem.UnitPrice < 0)
            {
                return;
            }
            _context.OrderItems.Add(orderItem);


        }
        public bool AddOrderItems(Dictionary<int, int> Menu, int orderId)
        {
            if (Menu == null) { return false; }

            if (Menu.Count == 0) { return false; }

            foreach (var item in Menu)
            {

                Product product = _context.Products.Where(p => p.Id == item.Key).Single();
                decimal unitPrice = product.salePrice;
                product.StockQuantity -= item.Value;
                OrderItem o = new OrderItem { ProductId = item.Key, UnitPrice = unitPrice, Quantity = item.Value, OrderId = orderId };
                AddOrderItem(o);

            }
            return _context.SaveChanges() > 0;
        }

        public List<Product> GetBestSellingProducts()
        {
            return _context.OrderItems
                .GroupBy(oi => oi.Product)
                .OrderByDescending(g => g.Sum(x => x.Quantity))
                .Select(g => g.Key)
                .ToList();
        }

        public decimal GetTotalProjectPenifit()
        {
            decimal CostPriceOfSalesGoods = GetTotalProjectSales();
            decimal SalePriceOfSalesGoods = _context.OrderItems.Sum(item => item.UnitPrice*item.Quantity);
            return SalePriceOfSalesGoods - CostPriceOfSalesGoods;
        }
        
        public decimal GetTotalProjectSales()
        {
            return _context.OrderItems.Sum(item => item.Product.costPrice * item.Quantity);
        }
    }

}
