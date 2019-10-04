using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using NLog.Web;
using System;

namespace Ingos.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Use NLog to catch all errors
            //
            var logger = NLogBuilder.ConfigureNLog("Configurations/nlog.config").GetCurrentClassLogger();

            try
            {
                logger.Info("Ingos.Api Init logging");
                CreateWebHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                logger.Error(ex, "Ingos.Api has been stopped because of this error");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .ConfigureLogging(logger =>
                {
                    logger.ClearProviders();
                    logger.SetMinimumLevel(LogLevel.Trace);
                })
                .UseNLog();
    }
}