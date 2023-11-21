using Application.Interfaces;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Repositories;
using WebApi;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Infrastructure.EntityFramework.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureEntityFramework(this IServiceCollection services, IConfiguration configuration)
        {
            return services
                .AddDbContext<SensieDbContext>(c => c.UseSqlServer(configuration.GetConnectionString("SalaoSensie")))
                .AddScoped<ICustomerRepository, CustomerRepository>()
                .AddScoped<ISchedulingRepository, SchedulingRepository>()
                .AddScoped<IServiceRepository, ServiceRepository>();
        }
    }
}
