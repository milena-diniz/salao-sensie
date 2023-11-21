using Application.Interfaces;
using Domain;

namespace WebApi.Repositories
{
    public class ServiceRepository : IServiceRepository
    {
        private readonly SensieDbContext _context;

        public ServiceRepository(SensieDbContext context)
        {
            _context = context;
        }
        public Service GetById(int id)
        {
            return _context.Services.First(s => s.Id == id);
        }
    }
}
