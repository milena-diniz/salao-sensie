using Application.Interfaces;
using Domain;

namespace WebApi.Repositories
{
    public class SchedulingRepository : ISchedulingRepository
    {
        private readonly SensieDbContext _context;

        public SchedulingRepository(SensieDbContext context)
        {
            _context = context;
        }

        public Scheduling Add(Scheduling model)
        {
            var entry = _context.Schedulings.Add(model);
            _context.SaveChanges();
            return entry.Entity;
        } 
    }
}
