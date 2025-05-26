using LAB11_WilliansMalque.Infrastructure.Configuration;
using Microsoft.OpenApi.Models;
using MediatR;
using System.Reflection;

namespace LAB11_WilliansMalque.API.Configuration;

public static class ServiceRegistrationExtension
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        // Registrar servicios de Infrastructure (BD, repositorios, etc.)
        services.AddInfrastructureServices(configuration);

        // Registrar MediatR usando Assembly
        services.AddMediatR(cfg =>
            cfg.RegisterServicesFromAssemblies(Assembly.Load("LAB11_WilliansMalque.Application")));

        // Configuración de Swagger para documentar la API
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "LAB11 API",
                Version = "v1",
                Description = "Documentación API para el laboratorio 11 usando CQRS y arquitectura hexagonal"
            });
            //agregar configuración adicional como seguridad JWT
        });

        // agregar más servicios globales, como autenticación, CORS, etc.

        return services;
    }
}