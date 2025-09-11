using Microsoft.Extensions.DependencyInjection;

namespace Tekus.ManagementProvider.Application
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {

            services.AddMediatR(configuration =>
            {
                configuration.RegisterServicesFromAssembly(typeof(ConfigureServices).Assembly);

            });

            return services;
        }
    }
}
