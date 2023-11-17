using Application.Interfaces;
using Domain;

namespace WebApi.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly SensieDbContext _context;

        public CustomerRepository(SensieDbContext context)
        {
            _context = context;
        }

        public Customer? GetByPhone(string phone)
        {
            return _context.Customers.FirstOrDefault(p => p.Phone == phone); 
        }

        public Customer Add(Customer customer) 
        {
            var entry = _context.Customers.Add(customer);
            _context.SaveChanges();
            return entry.Entity;
        }
    }
}
