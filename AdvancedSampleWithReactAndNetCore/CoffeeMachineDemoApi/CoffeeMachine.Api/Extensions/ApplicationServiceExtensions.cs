using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoffeeMachine.Api.Core;
using Microsoft.OpenApi.Models;

namespace CoffeeMachine.Api.Extensions
{
    public static class ServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
        {
            // EndPointApiExplorer
            services.AddEndpointsApiExplorer();

            // swagger
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "CoffeeMachine API", Version = "v1" });
            });

            // Database
            // services.AddDbContext<TodoDataContext>(options =>
            // {
            //     options.UseSqlite(configuration.GetConnectionString("DefaultConnection"));
            // });

            // Cors Policies
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", policy =>
                {
                    policy.AllowAnyMethod()
                        .AllowAnyHeader()
                        .WithOrigins("http://localhost:3000")
                        .WithOrigins("http://localhost:4000");
                });
            });

            //To Do: Add AutoRegistering for services
            services.AddSingleton<ICoffeeMachineBuilder, CoffeeMachineBuilder>();

            return services;
        }
    }
}