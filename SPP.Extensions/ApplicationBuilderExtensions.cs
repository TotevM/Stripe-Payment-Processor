using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
namespace SPP.Extensions
{
    public static class ApplicationBuilderExtensions
    {
        public static IApplicationBuilder ApplyMigrations(this IApplicationBuilder app)
        {
            using IServiceScope serviceScope = app.ApplicationServices.CreateScope();

            ApplicationDbContext dbContext = serviceScope
                .ServiceProvider
                .GetRequiredService<ApplicationDbContext>()!;
            dbContext.Database.Migrate();

            return app;
        }
    }
} 