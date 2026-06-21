namespace SalesMS.DAL.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public decimal costPrice {  get; set; }
        public decimal salePrice { get; set; }
        public int StockQuantity { get; set; }
        public float Rate {  get; set; }
        public string? ImagePath {  get; set; }


        // Navigation Property
        public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}