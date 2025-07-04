﻿using LAB11_WilliansMalque.Infrastructure.Configuration;
using Microsoft.OpenApi.Models;
using MediatR;
using System.Reflection;
using LAB11_WilliansMalque.Application.Configuration;

namespace LAB11_WilliansMalque.API.Configuration;

public static class ServiceRegistrationExtension
{
    public static IServiceCollection AddApiServices(this IServiceCollection services,
        IConfiguration configuration)
    {
        // Registrar servicios de Infrastructure (BD, repositorios, etc.)
        services.AddInfrastructureServices(configuration);
        // Application (CQRS)
        services.AddApplicationServices(configuration);


        // Configuración de Swagger
        services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "LAB11 API",
                Version = "v1",
                Description = "Documentación API para el laboratorio 11 usando CQRS y arquitectura hexagonal"
            });
        });

        return services;
    }
}