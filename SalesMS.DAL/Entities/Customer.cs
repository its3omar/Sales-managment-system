namespace SalesMS.DAL.Entities
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Email { get; set; }
        public decimal Balance { get; set; }

        // Navigation Property
        public ICollection<Order> Orders { get; set; } = new List<Order>();
    }

}
