using DinkToPdf;
using DinkToPdf.Contracts;
using DMSOShopping.Helper;
using DMSOShopping.Middlewares;
using DMSOShopping.Services;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DMSOShopping
{
    public class Startup
    {
        public readonly string CONNECTION_STRING;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            CONNECTION_STRING = Configuration.GetConnectionString("DefaultConnection");
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            // Html to pdf generator - DinkToPDF
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));

            services.AddControllersWithViews();

            services.AddDbContext<DataContext>(x => x.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")), ServiceLifetime.Scoped);


            services.AddMvc(o => o.EnableEndpointRouting = false);

            services.AddSession();

           


            services.AddAuthentication(
              CookieAuthenticationDefaults.AuthenticationScheme
          ).AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
              options =>
              {
                  options.LoginPath = "/Customers/Login";
                  options.LogoutPath = "/Customers/Logout";
                  options.AccessDeniedPath = "/Customers/AccessDenied";
              });

            services.AddTransient(
               m => new UserManager(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDistributedMemoryCache();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<IHelper, Services.Helper>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();
            app.UseSession();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Customers}/{action=Login}/{id?}");
            });
        }
    }
}
