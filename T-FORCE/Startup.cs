using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc.Razor;

namespace T_FORCE
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
            services.Configure<RazorViewEngineOptions>(o =>
            {
                o.ViewLocationFormats.Clear();

                o.ViewLocationFormats.Add
                    ("/{1}/Pages/{0}" + RazorViewEngine.ViewExtension);

                o.ViewLocationFormats.Add
                    ("/Users/Pages/{0}" + RazorViewEngine.ViewExtension);

                o.ViewLocationFormats.Add
                    ("/GenericViews/Shared/{0}" + RazorViewEngine.ViewExtension);

                o.PageViewLocationFormats.Add
                ("/{1}/Pages/Partials/{0}" + RazorViewEngine.ViewExtension);

            });

            services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme,
                options =>
                {
                    options.LoginPath = new PathString("/User/Login/");
                    options.AccessDeniedPath = new PathString("/User/Forbidden/");
                });

            services.Configure<AuthenticationOptions>(options =>
            {
                options.RequireAuthenticatedSignIn = false;
            });

            services.AddMvc();

            services.AddControllersWithViews();

            IAppDbContextFactory IAppDbContextFactory = new AppDbContextFactory();

            AppDbContext appDbContext = IAppDbContextFactory.CreateAppDbContext();

            services.AddDbContext<AppDbContext>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            app.UseAuthentication();

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
