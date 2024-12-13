using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using UserRegistration.Api.Enums;
using UserRegistration.Api.Extencions;
using UserRegistration.Infraestructure.DataAccess;

namespace UserRegistration.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using (var serviceScope = host.Services.CreateScope())
            {
                var services = serviceScope.ServiceProvider;
                var dbConfigContext = services.GetRequiredService<UserRegistrationDbContext>();

                if (!dbConfigContext.Database.CanConnect())
                {
                    dbConfigContext.Database.Migrate();
                }

                if (dbConfigContext.IsDataFetched() != DBState.Fetched)
                {
                    dbConfigContext.FetchDataBase();
                }
            }

            host.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
