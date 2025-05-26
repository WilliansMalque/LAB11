using LAB11_WilliansMalque.Infrastructure.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;

namespace LAB11_WilliansMalque.Infrastructure.Configuration;

public static class InfrastructureServicesExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        // DataBase Connection
        services.AddDbContext<AppDbContext>((serviceProvider, options) =>
        {
            var connectionString = configuration.GetConnectionString("DefaultConnection");

            // Configura MySQL con la versión del servidor
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
        });
        
        //Services Register
        return services;
    }
}