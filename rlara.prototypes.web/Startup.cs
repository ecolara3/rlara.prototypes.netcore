﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using rlara.prototypes.data;
using rlara.prototypes.identity;
using rlara.prototypes.identity.Entities;
using rlara.prototypes.web.Models;

namespace rlara.prototypes.web
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
            services.AddDbContext<StoreDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("StoreConnection"), b => b.MigrationsAssembly("rlara.prototypes.web")));
            services.AddDbContext<UserDBContext>(options => options.UseSqlServer(Configuration.GetConnectionString("IdentityConnection"), b => b.MigrationsAssembly("rlara.prototypes.web")));
            services.Configure<AppSettings>(Configuration.GetSection("AppSettings"));
            services.AddIdentity<User, Role>().AddEntityFrameworkStores<UserDBContext>().AddDefaultTokenProviders();

            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();
            app.UseAuthentication();
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}