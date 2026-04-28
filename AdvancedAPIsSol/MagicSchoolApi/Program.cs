using MagicSchoolApi.Controllers;
using MagicSchoolApi.Repository;
using MagicSchoolApi.Service;
using Microsoft.Extensions.Diagnostics.HealthChecks;

namespace MagicSchoolApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<ISpellService, SpellService>();
            builder.Services.AddScoped<ISpellRepository, SpellRepository>();
            builder.Services.AddHealthChecks()
            .AddCheck<ProductHealthCheck>("product_file_health_check",
            failureStatus: HealthStatus.Unhealthy,
            tags: new[] { "file", "products" });

            var app = builder.Build();

            app.UseHealthChecks("/health");
        


       

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}
