﻿using System.Diagnostics.CodeAnalysis;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Serilog;
using Serilog.Core;

namespace Assessment.Core.Common
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
            
            services.AddDbContext<TDbContext>(options => options.UseSqlite(connectionString,
                    x => x.MigrationsAssembly("Assessment.Infrastructure")));
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