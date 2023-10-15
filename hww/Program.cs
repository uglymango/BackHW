using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace hww
{
    public class Program
    {
        public static void Main(string[] args)
        {
            
            var builder = WebApplication.CreateBuilder(args);

            builder.Services
    .AddControllersWithViews()
    .AddRazorRuntimeCompilation();

            var app = builder.Build();

            app.UseStaticFiles();

            app.MapControllerRoute("default", "{controller}/{action}");

            app.Run();
        }
    }
}