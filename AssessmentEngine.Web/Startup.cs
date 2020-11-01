using System;
using AssessmentEngine.Core.Common;
using AssessmentEngine.Domain.Entities;
using AssessmentEngine.Infrastructure.Contexts;
using AssessmentEngine.Web.Areas.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace AssessmentEngine.Web
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            ConfigureSettings(services);
            Program.Bootstrapper.ConfigureLogging(services);
            Program.Bootstrapper.ConfigureDbContext<ApplicationDbContext>(services);
            ConfigureAspNetIdentity<ApplicationDbContext, ApplicationUser, ApplicationRole>(services);
            DependencyContainer.Configure(services);
            ConfigureUI(services);
        }

        private void ConfigureSettings(IServiceCollection services)
        {
            services.Configure<EFTSettings>(Configuration.GetSection(EFTSettings.EFT));
        }

        private static void ConfigureUI(IServiceCollection services)
        {
            var builder = services.AddRazorPages();

#if DEBUG
            builder.AddRazorRuntimeCompilation();
#endif
        }

        private static void ConfigureAspNetIdentity<TIdentityContext, TIdentityUser, TIdentityRole>(IServiceCollection services)
            where TIdentityContext : DbContext
            where TIdentityUser : class
            where TIdentityRole : class

        {
            services.AddDefaultIdentity<TIdentityUser>(options =>
                    {
                        options.SignIn.RequireConfirmedAccount = false;
                        options.Lockout.DefaultLockoutTimeSpan = TimeSpan.MaxValue;
                        options.Lockout.MaxFailedAccessAttempts = 5;
                    })
                .AddRoles<TIdentityRole>()
                .AddEntityFrameworkStores<TIdentityContext>();
            services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<TIdentityUser>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseDatabaseErrorPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                //app.UseHsts(); // todo: Uncomment once https configured on server
                
                // Used for nginx reverse proxy
                app.UseForwardedHeaders(new ForwardedHeadersOptions
                {
                    ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
                });
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            if (bool.TryParse(Configuration["RunMigrationsOnStartup"], out bool runMigrations) && runMigrations)
            {
                Program.Bootstrapper.EnsureCreated<ApplicationDbContext>(app);
            }

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapControllerRoute(
                    name: "Identity",
                    pattern: "{area:exists}/{controller}/{action}/{id?}");
                endpoints.MapControllerRoute(
                    name: "Tasks",
                    pattern: "{area:exists}/{controller}/{action}/{id?}",
                    defaults: new { action = "Index" });
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller}/{action}/{id?}");
                endpoints.MapRazorPages();
            });
        }
    }
}