using WebApi.DTO;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class CustomerRepository
    {
        private readonly ApplicationDbContext _context;

        public CustomerRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public CustomerModel? GetByPhone(string phone)
        {
            return _context.Customers.FirstOrDefault(p => p.Phone == phone); 
        }

        public CustomerModel Add(CustomerDto customer) 
        {
            var newCustomer = new CustomerModel
            {
                Name = customer.Name,
                Phone = customer.Phone, 
            };

            var entry = _context.Customers.Add(newCustomer);
            _context.SaveChanges();

            return entry.Entity;
        }
    }
}
