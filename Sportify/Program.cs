using Microsoft.EntityFrameworkCore;
using Sportify.Data;

namespace Sportify;

public class Program
{

    public static async Task Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at 
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddDbContext<SportifyDbContext>(
            opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("SportifyDb")));

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        // Configure the HTTP request pipeline and apply DB migrations if necessary
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
            await EnsureDatabaseIsMigrated(app.Services);
        }

        app.UseAuthorization();
        app.MapControllers();
        app.Run();
    }
    static async Task EnsureDatabaseIsMigrated(IServiceProvider services)
    {
        using var scope = services.CreateScope();
        using var ctx = scope.ServiceProvider.GetService<SportifyDbContext>();
        if (ctx is not null)
        {
            await ctx.Database.MigrateAsync();
        }
    }
}