using Microsoft.EntityFrameworkCore;

namespace SalesMS.BLL.Services
{
    public class CustomerService
    {
        private readonly AppDbContext _context;
        public CustomerService(AppDbContext context)
        {
            _context = context;
        }
        public bool UpdateBalance(int customerId,decimal amount)
        {
            Customer? customer = GetCustomerById(customerId);
            if (customer == null)
            {
                return false;
            }
            customer.Balance += amount;
            return _context.SaveChanges() > 0;
        }
        public bool Deposit(int customerId, decimal amount)
        {
            if (amount < 0)
            {
                return false;
            }
            
                bool isUpdated = UpdateBalance(customerId, amount);
                return isUpdated;
            
            
        }
        public bool deductOrderPrice(int customerId,decimal totalPrice)
        {
            if (totalPrice < 0) 
            { 
                return false; 
            }
            bool isUpdated = UpdateBalance(customerId,-totalPrice);
            return isUpdated;
        }

        public IQueryable<Customer> GetAllCustemers()
        {
            return _context.Customers;
        }
        public Customer? GetCustomerById(int id)
        {
            return _context.Customers.Find(id);
        }
        public bool AddNewCustomer(Customer c)
        {
            if (c == null) { return false; }

            if (string.IsNullOrEmpty(c.Name)
                || string.IsNullOrEmpty(c.Email)
                || string.IsNullOrEmpty(c.Phone)) { return false; }

                _context.Customers.Add(c);
            return (_context.SaveChanges() > 0);
        }
        public bool DeleteCustomer(int id)
        {
            Customer? c = GetCustomerById(id);
            if (c == null) { return false; }

            _context.Customers.Remove(c);
            return (_context.SaveChanges() > 0);

        }
        public bool UpdateCustomer(int CustomerId,string name,string email,string phoneNumber)
        {
            Customer ?c= GetCustomerById(CustomerId);
            if (c == null) { return false; }
            if (string.IsNullOrEmpty(name)
                || string.IsNullOrEmpty(email)
                || string.IsNullOrEmpty(phoneNumber)) { return false; }

            c.Name = name;
            c.Email = email;
            c.Phone = phoneNumber;
            return _context.SaveChanges() > 0;
        }
        public Customer? Login(string username,string email)
        {
            return (_context.Customers.FirstOrDefault(c => c.Name == username && c.Email == email));
        }
        public List<Customer> GetValuedCustomers()
        {
            return _context.Customers.OrderByDescending(c => c.Orders.Count).Take(5).ToList();
     
        }
        public int CountTotalCustomers()
        {
            return _context.Customers.Count();
        }
    }
}