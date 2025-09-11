using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tekus.ManagementProvider.Domain.Abstractions;
using Tekus.ManagementProvider.Domain.Entities.Providers;
using Tekus.ManagementProvider.Infrastructure.Contexts;
using Tekus.ManagementProvider.Infrastructure.Repositories;

namespace Tekus.ManagementProvider.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("connection")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IProviderRepository, ProviderRepository>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));


            return services;
        }
    }
}
