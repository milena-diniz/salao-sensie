using WebApi.Models;

namespace WebApi.Repositories
{
    public class ServiceRepository
    {
        private readonly ApplicationDbContext _context;

        public ServiceRepository(ApplicationDbContext context)
        {
            _context = context;
        }
        public ServiceModel GetById(int id)
        {
            return _context.Services.First(s => s.Id == id);
        }
    }
}
