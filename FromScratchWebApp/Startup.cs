using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;

namespace FromScratchWebApp
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();              //Adds MVC to our project
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            //The order of app.Use here is of importans as it determens i what order the requests are prossesed and in reversed order when it sends back the response
            // this segmant is also referd to as Middlewere or pipeline

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();           //Allowes os to use the files in the "wwwroot" folder

            app.UseMvcWithDefaultRoute();   //Controller = Home & Action = Index

            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync("<h1>ASP.NET Rules!</h1>");
            //});
        }
    }
}
