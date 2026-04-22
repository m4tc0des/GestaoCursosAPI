using GestaoCursos.Domain.Interfaces;
using GestaoCursos.Infrastructure.Context;
using GestaoCursos.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GestaoCursos.Infrastructure.Configurations
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddScoped<ICourseRepository, CourseRepository>();

            var connectionString = configuration.GetConnectionString("AppConnectionString");

            services.AddDbContext<ApplicationDbContext>(x => x.UseMySql (connectionString, ServerVersion.AutoDetect(connectionString)) );

            return services;
        }
    }
}
