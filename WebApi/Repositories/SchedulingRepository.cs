using WebApi.DTO;
using WebApi.Models;

namespace WebApi.Repositories
{
    public class SchedulingRepository
    {
        private readonly ApplicationDbContext _context;

        public SchedulingRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public SchedulingModel Add(SchedulingModel model)
        {
            var entry = _context.Schedulings.Add(model);
            _context.SaveChanges();
            return entry.Entity;
        } 
    }
}
