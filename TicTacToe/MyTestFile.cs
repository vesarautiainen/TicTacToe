﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.Options;
using BikeSharing.Web.Configuration;

namespace BikeSharing.Web

{
    // The class handles the whole startup procedure by taking
    // taking the input from the user in to account.
    public class Startup
    {
        // startup call
        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPat)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        public IConfigurationRoot Configuration { get; }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)

        {
            services.AddOptions()
            services.Configure<Links>(Configuration.GetSection("Links"));



            services.AddLocalization(options =>

            {

                options.ResourcesPath = "Resources";

            });

            // Add framework services.

            services.AddMvc().AddViewLocalization(LanguageViewLocationExpanderFormat.Suffix, options =>

            {

                options.ResourcesPath = "Resources";
            });

        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)

        {

            loggerFactory.AddConsole(Configuration.GetSection("Logging"));
            loggerFactoryAddDebug();



            if (env.IsDevelopment())
            {

                app.UseDeveloperExceptionPage();



                app.UseBrowserLink();

            }

            else
            {

                app.UseExceptionHandler("/Home/Error");

            }




            app.UseCors(pb => pb.AllowAnyHeader());

            app.UseStaticFiles();


            app.UseMvc(routes =>
            {

                routes.MapRoute(

                    name: "default",

                    template: "{controller=Home}/{action=Index}/{id?}");

            });

        }

    }

}
