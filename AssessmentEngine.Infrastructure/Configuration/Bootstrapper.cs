using System;
using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Serilog;
using Serilog.Core;

namespace AssessmentEngine.Core.Common
{
    [SuppressMessage("ReSharper", "InconsistentNaming", Justification = "Configuration keys")]
    public class Bootstrapper
    {
        public Bootstrapper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        private readonly IConfiguration _configuration;
        private bool UseIIS => _configuration["WebServer"]?.ToLower() == "iis";
        private string DbProviderType => _configuration["DbProviderType"];
        private IConfigurationSection ConnectionStrings => _configuration.GetSection("ConnectionStrings");
        
        public Logger CreateLogger() 
            => new LoggerConfiguration()
                .ReadFrom.Configuration(_configuration)
                .CreateLogger();
        
        public void ConfigureLogging(IServiceCollection services) 
            => services.AddLogging(loggingBuilder => loggingBuilder.AddSerilog(dispose: true));

        public void ConfigureWebBuilder<TStartup>(IWebHostBuilder webBuilder) where TStartup : class
        {
            webBuilder.UseSerilog();
            webBuilder.UseStartup<TStartup>();
            
            if (UseIIS)
                webBuilder.UseIIS();
        }

        public void ConfigureDbContext<TDbContext>(IServiceCollection services) where TDbContext : DbContext
        {
            var connectionString = ConnectionStrings[typeof(TDbContext).Name];
            
            switch (DbProviderType)
            {
                case "sqlite":
                    // todo: verify db file exists when sqlite
                    services.AddDbContext<TDbContext>(options => options.UseSqlite(connectionString,
                        x => x.MigrationsAssembly("AssessmentEngine.Infrastructure")));
                    break;
                case "postgres":
                    services.AddDbContext<TDbContext>(options =>
                    {
                        options.UseNpgsql(connectionString, x => x.MigrationsAssembly("AssessmentEngine.Infrastructure"));
                    });
                    break;
                default:
                    throw new NotSupportedException($"DbProviderType {DbProviderType} is not supported. Supported db types: sqlite, PostgreSQL");
            }
        }
        
        public void EnsureCreated<TDbContext>(IApplicationBuilder app)
            where TDbContext : DbContext
        {
            using var serviceScope = app.ApplicationServices
                .GetRequiredService<IServiceScopeFactory>()
                .CreateScope();
            
            using var context = serviceScope.ServiceProvider.GetService<TDbContext>();
            context.Database.EnsureCreated();
        }
    }
}