using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Assessment.Core.Common;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Serilog;

namespace Assessment.Web
{
    public class Program
    {
        public static readonly Bootstrapper Bootstrapper = new Bootstrapper(Configuration);

        public static void Main(string[] args)
        {
            Log.Logger = Bootstrapper.CreateLogger();

            StartWebApp(args);
        }
        
        private static void StartWebApp(string[] args)
        {
            try
            {
                CreateHostBuilder(args).Build().Run();

                Log.Information("Started web host with {environment} environment settings", Environment);
            }
            catch (Exception ex)
            {
                Log.Error(ex, "Failed to start app");

                throw;
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }
        
        private static IHostBuilder CreateHostBuilder(string[] args) 
            => Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    Bootstrapper.ConfigureWebBuilder<Startup>(webBuilder);
                });
     
        private static IConfiguration Configuration
            => GetConfiguration(Environment);
        
        private static string Environment 
            => new WebHostBuilder().GetSetting("environment");
        
        private static IConfiguration GetConfiguration(string environment) 
            => new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{environment}.json", optional: true)
                .AddEnvironmentVariables()
                .Build();
        
        
    }
}