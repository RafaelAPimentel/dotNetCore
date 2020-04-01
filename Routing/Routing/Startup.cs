using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Routing
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddRouting();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.UseRouter( builder =>
            {
                builder.MapRoute(string.Empty, context => {
                    return context.Response.WriteAsync($"Welcome to the default route!");
                });

                builder.MapGet("foo/{name}/{surname?}", (request, response,routeData) => {
                    return response.WriteAsync($"Welcome to Foo, {routeData.Values["name"]} {routeData.Values["surname"]}");
                });

                builder.MapPost("bar/{number:int}", (request,response,routeData) => {
                    return response.WriteAsync($"Welcome to Bar, number is {routeData.Values["number"]}");
                });
            });
        }
    }
}
