using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;

namespace CleverClass.Domain.Rest
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            app.Run(async (context) =>
            {
                await context.Response.WriteAsync("Hello World!");
            });
        }
    }
    
    public static void Main(string[] args) => WebApplication.Run<Startup>(args);
}