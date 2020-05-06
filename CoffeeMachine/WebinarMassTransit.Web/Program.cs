using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using WebinarMassTransit.Common;

namespace WebinarMassTransit.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
                   Host.CreateDefaultBuilder(args)
                    .AddLoggingConfigurationFile()
                    .AddDatabaseConfigurationFile()
                    .AddRabbitMQConfigurationFile()
                    .ConfigureWebHostDefaults(webBuilder =>
                    {
                        webBuilder.UseStartup<Startup>().ConfigureSerilog();
                    });
    }
}
