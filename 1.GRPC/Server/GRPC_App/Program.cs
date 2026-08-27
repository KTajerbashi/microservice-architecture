
using GRPC_App.GRPC;
using Microsoft.OpenApi;

namespace GRPC_App;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // OpenAPI
        builder.Services.AddOpenApi();

        builder.Services.AddEndpointsApiExplorer();

        //builder.Services.AddSwaggerGen(options =>
        //{
        //    options.SwaggerDoc("v1", new()
        //    {
        //        Title = "My API",
        //        Version = "v1",
        //        Description = "My ASP.NET Core 10 API"
        //    });
        //});

        builder.Services.AddGrpc();

        builder.Services.AddSwaggerGen(options =>
        {
            options.SwaggerDoc("v1", new OpenApiInfo
            {
                Title = "My API",
                Version = "v1"
            });

            options.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                Scheme = "bearer",
                BearerFormat = "JWT",
                In = ParameterLocation.Header,
                Description = "Enter your JWT token."
            });

            //options.AddSecurityRequirement(new OpenApiSecurityRequirement
            //{
            //    {
            //        new OpenApiSecurityScheme
            //        {
            //            Reference = new OpenApiReference
            //            {
            //                Type = ReferenceType.SecurityScheme,
            //                Id = "Bearer"
            //            }
            //        },
            //        Array.Empty<string>()
            //    }
            //});
        });

        var app = builder.Build();

        // OpenAPI document
        if (app.Environment.IsDevelopment())
        {
            app.MapOpenApi();
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthentication();

        app.UseAuthorization();

        app.MapControllers();

        app.MapGrpcService<ProductWebService>();

        app.Run();
    }
}

