using Imaginarium.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Imaginarium.Bot
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = ConfigureServices();

            serviceProvider.GetService<DiscordBot>().Run();
        }

        private static ServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection()
                .AddTransient<DiscordBot>();

            IConfiguration configuration = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .Build();

            string connectionString = configuration.GetConnectionString("DefaultConnection");
            services.AddDbContext<ApplicationContext>(options
                => options.UseSqlServer(connectionString, builder
                    => builder.MigrationsAssembly("Imaginarium.Persistance")));

            return services.BuildServiceProvider();
        }
    }
}
