using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;
using System.Reflection;

namespace BYNOGAME.API.Extensions
{
    public static class MiddlewareExtensions
    {
        public static IServiceCollection AddCustomSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(cfg =>
            {
                cfg.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Bynogame.com",
                    Version = "v0.01",
                    Description = "Basit bynogame .API 'si",
                    Contact = new OpenApiContact
                    {
                        Name = "Bynogame.com",
                        Url = new Uri("https://bynogame.com/")
                    },
                    License = new OpenApiLicense
                    {
                        Name = "BYNOLICENCE",
                    },
                });

                var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
                var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
                cfg.IncludeXmlComments(xmlPath);
            });
            return services;
        }

        public static IApplicationBuilder UseCustomSwagger(this IApplicationBuilder app)
        {
            app.UseSwagger().UseSwaggerUI(options =>
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "BYNOGAME API");
                options.DocumentTitle = "Bynogame API";
            });
            return app;
        }
    }
}
