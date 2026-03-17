namespace SalesMS.BLL.Services
{
    public class ProductService
    {
        private readonly AppDbContext _context;
        public ProductService(AppDbContext context)
        {
            _context = context;
        }
        public Product? GetProductById(int id)
        {
            return _context.Products.Find(id);
        }
        public bool IncreaseProductByOne(int productId)
        {
            Product? product = GetProductById(productId);
            if (product == null) { return false; }
            product.StockQuantity++;
            return _context.SaveChanges() > 0;
        }

        private bool isValidProduct(Product product)
        {
            if (product == null)
            {
                return false;
            }
            if (product.salePrice < 0)
            {
                return false;
            }
            if (product.costPrice < 0)
            {
                return false;
            }
            return true;
        }
        public bool CreateNewProduct(Product product)
        {
            if (!isValidProduct(product)) { return false; }
            
            product.StockQuantity = 1;
            _context.Add(product);
            return _context.SaveChanges() > 0;

        }

        public bool UpdateProduct(Product product)
        {
            if(!isValidProduct(product)) { return false; }
            else
            {
                _context.Products.Update(product);
                return (_context.SaveChanges() > 0);
            }
        }
        public List<Product> GetAllProducts(string name=null)
        {
            if (name == null)
            {
                return _context.Products.ToList();
            }
            return _context.Products
               .Where(p => p.Name.Contains(name))
               .ToList();
        }
        public List<Product> GetOutOfStuckProducts()
        {
            return _context.Products.Where(p=>p.StockQuantity == 0).ToList();
        }
        public decimal CalculateTotalCapitalOfStore()
        {
            return _context.Products.Sum(p => p.StockQuantity * p.costPrice);
        }
        public int CalculateTotalProductsCount()
        {
            return _context.Products.Count();
        }

    }
}