using back_end_registro_usuarios.Extencions;
using Infraestructure.DataAccess;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace back_end_registro_usuarios
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
