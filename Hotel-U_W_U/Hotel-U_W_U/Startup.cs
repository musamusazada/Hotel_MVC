using Hotel_U_W_U.Constants;
using Hotel_U_W_U.DAL;
using Hotel_U_W_U.Models.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel_U_W_U
{
    public class Startup
    {

        private IConfiguration Configuration { get; }
        private IWebHostEnvironment _env { get; }
        public Startup(IConfiguration configuration, IWebHostEnvironment env)
        {
            Configuration = configuration;
            _env = env;
        }


        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSession();
            services.AddMvc().AddNewtonsoftJson(options => options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore).AddNewtonsoftJson(options =>
            {
                options.SerializerSettings.DateFormatString = "dd-MM-yyyy";
            });
            services.AddDbContext<AppDbContext>(options => options.UseSqlServer(this.Configuration.GetConnectionString("Default"), builder =>
            {
                builder.MigrationsAssembly("Hotel-U_W_U");
            }));
            services.AddIdentity<User, IdentityRole>(options =>
             {
                 options.Password.RequireUppercase = true;
                 options.Password.RequireDigit = true;
                 options.Password.RequiredLength = 10;
                 options.User.RequireUniqueEmail = true;
                 options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(5);
                 options.Lockout.MaxFailedAccessAttempts = 3;

             }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            FileConstants.imagePath = Path.Combine(_env.WebRootPath);
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

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                 name: "areas",
                 pattern: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
                );
                endpoints.MapControllerRoute("default", "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
