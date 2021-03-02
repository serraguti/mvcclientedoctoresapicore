using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MvcDoctoresClienteApi.Services;

namespace MvcDoctoresClienteApi
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            String urldoctores = "https://apidoctorpgs.azurewebsites.net/";
            //INYECCION SIN URL
            services.AddTransient<ServiceApiDoctores>();
            //INYECCION CON URL
            //services.AddTransient(x => new ServiceApiDoctores(urldoctores));
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            app.UseStaticFiles();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
