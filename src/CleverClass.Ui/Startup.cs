using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.PlatformAbstractions;
using System.IO;

namespace CleverClass.Ui
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();
            loggerFactory.AddDebug();
            
            app.UseIISPlatformHandler();
            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseMvc();
        }

        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseServer("Microsoft.AspNetCore.Server.Kestrel")
                .UseApplicationBasePath(Directory.GetCurrentDirectory())
                .UseDefaultConfiguration(args)
                .UseIISPlatformHandlerUrl()
                .UseStartup<Startup>()
                .UseUrls("http://localhost:5001")
                .Build();

            host.Run();
        }
    }
}