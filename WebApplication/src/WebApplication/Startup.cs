using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Routing;

using Microsoft.Framework.DependencyInjection;

namespace WebApplication
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();
        }


        public void Configure(IApplicationBuilder app)
        {
            // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940

            //app.UseWelcomePage();

            app.UseMvc(route =>
            {
                route.MapRoute(
                    name: "default",
                    template: " {controller}/{action}/{id?}",
                    defaults: new { controller = "home", action = "index" }
                    );
            });

            //app.Run(context =>
            //{
            //    return context.Response.WriteAsync("coucou vous");
            //});
        }
    }
}
