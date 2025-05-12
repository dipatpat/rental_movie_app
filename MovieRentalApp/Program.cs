using Microsoft.OpenApi.Models;
using MovieRentalApp.Middlewares;
using Swashbuckle.AspNetCore.SwaggerUI;

namespace MovieRentalApp;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddAuthorization();

        // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
        builder.Services.AddOpenApi();
        
        builder.Services.AddSwaggerGen(c =>
        {
            c.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "Movie Rental API",
                Version = "v1",
                Description = "Rest API for managing Movie Rental",
                Contact = new OpenApiContact
                {
                    Name = "API Suppoert",
                    Email = "support@example.com",
                    Url = new Uri("https://example/support")
                },
                License = new OpenApiLicense
                {
                    Name = "MIT License",
                    Url = new Uri("https://opensource.org/licenses/MIT")
                }
            });
        });

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
        }
        
        app.UseSwagger();
    
        //Enable middleware to serve swagger-ui
        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Movie Rental v1");

            //Basic UI Customization
            c.DocExpansion(DocExpansion.List);
            c.DefaultModelsExpandDepth(0); //Hide schemas section by default
            c.DisplayRequestDuration(); //Show request duration
            c.EnableFilter(); //Enable filtering operration
        });
        
        app.UseGlobalExceptionHandling(); 
        app.UseSwagger();

        app.UseSwaggerUI(c =>
        {
            c.SwaggerEndpoint("/swagger/v1/swagger.json", "Movie Rental API v1");

            c.DocExpansion(DocExpansion.List);
            c.DefaultModelsExpandDepth(0); 
            c.DisplayRequestDuration();
            c.EnableFilter(); 
        });


        app.UseHttpsRedirection();

        app.UseAuthorization();
        
        app.Run();
    }
}