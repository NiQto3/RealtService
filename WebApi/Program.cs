using RealtService.Application;
using RealtService.Persistence;
using RealtService.WebApi.Middleware;
using System.Net;

namespace RealtService.WebApi;

public static class Program
{
    public static async Task Main(string[] args)
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        WebApplicationBuilder builder = WebApplication.CreateBuilder(args);
        builder.WebHost.UseKestrel(options => options.Listen(IPAddress.Loopback, 80));
        builder.Services
            .AddPersistanceServices(configuration)
            .AddApplicationServices()
            .AddWebApiServices();

        WebApplication app = builder.Build();
        app.UseMiddleware<GlobalErrorHandler>();
        app.UseRouting();
        app.UseHttpsRedirection();
        app.UseCors("AllowAll");
        app.MapControllers();
        await app.RunAsync();
    }
}