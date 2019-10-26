using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MoustacheApp.Data;
using MoustacheApp.Services;
using MoustacheApp.Models;

namespace MoustacheApp
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
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddTransient<ICurrentUserService, CurrentUserService>();

            services.AddDbContext<ApplicationDbContext>(options =>
                options.UseMySql(
                    Configuration.GetConnectionString("ServerConnection")));

            //services.AddDefaultIdentity<AppUser>()
            //    .AddDefaultUI(UIFramework.Bootstrap4)
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            // Roles: Both of the following appear to work the same (MB 20190928)
            // AddDefaultIdentity calls 'AddDefaultTokenProviders' so it doesn't need to include it
            services.AddIdentity<AppUser, AppRole>(config =>
                {
                    //  *prevents registered users from logging in until their email is confirmed.
                    //config.SignIn.RequireConfirmedEmail = true;
                })
                  .AddDefaultUI(UIFramework.Bootstrap4)
                  .AddDefaultTokenProviders()
                  .AddEntityFrameworkStores<ApplicationDbContext>();
            //services.AddDefaultIdentity<AppUser>()
            //    .AddDefaultUI(UIFramework.Bootstrap4)
            //    .AddRoles<AppRole>()
            //    .AddEntityFrameworkStores<ApplicationDbContext>();

            // Add application services
            //services.AddTransient<IEmailSender, EmailSender>();
            services.AddTransient<IEmailSender, EmailSender>(i =>
                new EmailSender(
                    Configuration["EmailSender:Host"],
                    Configuration.GetValue<int>("EmailSender:Port"),
                    Configuration.GetValue<bool>("EmailSender:EnableSSL"),
                    Configuration["EmailSender:UserName"],
                    Configuration["EmailSender:Password"]
                )
            );

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            if  (Configuration["Hosting"] == "local")
            {
                app.UseHttpsRedirection();
            }
            app.UseStaticFiles();
            app.UseCookiePolicy();

            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
                    //template: "{controller=MoQuizDetails}/{action=Index}/{id?}");
        });
        }
    }
}
