using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Tekus.ManagementProvider.Domain.Entities.CustomsFields;
using Tekus.ManagementProvider.Domain.Entities.Providers;
using Tekus.ManagementProvider.Domain.Entities.ProvidersServices;
using Tekus.ManagementProvider.Domain.Entities.Services;

namespace Tekus.ManagementProvider.Infrastructure.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Provider> Providers { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ProviderService> ProvidersServices { get; set; }
        public DbSet<ProviderCustomField> CustomFields { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
