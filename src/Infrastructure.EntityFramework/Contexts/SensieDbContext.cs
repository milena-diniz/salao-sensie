using Domain;
using Microsoft.EntityFrameworkCore;

namespace WebApi
{
    public class SensieDbContext : DbContext
    {
        public SensieDbContext(DbContextOptions<SensieDbContext> options) 
            : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Scheduling> Schedulings { get; set; }
        public DbSet<Service> Services { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder) 
            => modelBuilder.ApplyConfigurationsFromAssembly(typeof(SensieDbContext).Assembly);
    }
}
