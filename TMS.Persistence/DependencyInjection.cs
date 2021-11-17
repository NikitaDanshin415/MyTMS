using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using TMS.Application.Interfaces;

namespace TMS.Persistence
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddPersistence(this IServiceCollection
            services, IConfiguration configuration)
        {
            var connectionString = configuration["DbConnection"];
            services.AddDbContext<TmsDbContext>(options =>
            {
                options.UseSqlServer(connectionString);
            });

            services.AddScoped<ITmsDbContext>(provider =>
                provider.GetService<TmsDbContext>());
           
            return services;
        }
    }
}