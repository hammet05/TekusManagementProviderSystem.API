using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Tekus.ManagementProvider.Infrastructure.Contexts;

namespace Tekus.ManagementProvider.Infrastructure
{
    public static class ConfigureServices
    {
        public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
               options.UseSqlServer(configuration.GetConnectionString("connection")));

            //services.AddScoped<IUnitOfWork, UnitOfWork>();
            //services.AddScoped<IStudentRepository, StudentRepository>();
            //services.AddScoped<ITeacherRepository, TeacherRepository>();
            //services.AddScoped<ICourseRepository, CourseRepository>();
            //services.AddScoped<IEnrollmentRepository, EnrollmentRepository>();

            return services;
        }
    }
}
