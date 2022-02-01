using Microsoft.EntityFrameworkCore;
using Repository;

namespace InspectionAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                builder.WithOrigins("http://localhost:4200")
                .AllowAnyMethod()
                .AllowAnyHeader());
            });

        public static void AddSqlContext(this IServiceCollection services, IConfiguration configuration) {
            services.AddDbContext<RepositoryContext>(options => {
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
            });
        }


    }
}
