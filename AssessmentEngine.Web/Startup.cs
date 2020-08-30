using AssessmentEngine.Core.Common;
using AssessmentEngine.Domain.Identity;
using AssessmentEngine.Infrastructure.Contexts;
using AssessmentEngine.Web.Areas.Identity;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
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
            Program.Bootstrapper.ConfigureLogging(services);
            Program.Bootstrapper.ConfigureDbContext<ApplicationDbContext>(services);
            ConfigureAspNetIdentity<ApplicationDbContext, ApplicationUser, ApplicationRole>(services);
            DependencyContainer.Configure(services);
            ConfigureUI(services);
        }

        private static void ConfigureUI(IServiceCollection services)
        {
            services.AddRazorPages();
            services.AddServerSideBlazor();
        }

        private static void ConfigureAspNetIdentity<TIdentityContext, TIdentityUser, TIdentityRole>(IServiceCollection services)
            where TIdentityContext : DbContext
            where TIdentityUser : class
            where TIdentityRole : class

        {
            services.AddDefaultIdentity<TIdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
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
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                endpoints.MapRazorPages();
            });
        }
    }
}