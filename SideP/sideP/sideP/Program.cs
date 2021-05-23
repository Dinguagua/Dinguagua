using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Serilog;
using Serilog.Events;

namespace sideP
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var template = "{Timestamp:yyyy/MM/dd HH:mm:ss}[{Level}] {Message}{NewLine}{Exception}";
            string time = DateTime.Now.ToString("yyyy-MM-dd");
            //
            // Log.Logger = new LoggerConfiguration()
            //     .MinimumLevel.Debug()
            //     .MinimumLevel.Override("Microsoft", LogEventLevel.Information)
            //     .Enrich.FromLogContext().WriteTo.File($"logs/log-{time}.txt", outputTemplate: template)
            //     .WriteTo.Console()
            //     .CreateLogger();
            // try
            // {
            //     Log.Information("Starting web host");  // Log ¬ö¿ý¶}©l¡I
            //     CreateHostBuilder(args).Build().Run();
            // }
            // catch (Exception ex)
            // {
            //     Log.Fatal(ex, "Host terminated unexpectedly");
            // }
            // finally
            // {
            //     Log.CloseAndFlush();
            // }
            var configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(configuration).WriteTo.File($"logs/{time}.txt", outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {Message:lj} {Properties:j}{NewLine}{Exception}").CreateLogger();
            Log.Information("Starting web host");

            CreateHostBuilder(args).Build().Run();

          

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureLogging((hostingContext, logging) =>
                {
                    logging.ClearProviders();
                })
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                }).UseSerilog();// LOG
    }
}
