using UserRegistration.Api.MapConfiguration;
using UserRegistration.Domin.Entites;
using UserRegistration.Infraestructure.DataAccess;
using UserRegistration.Infraestructure.Insterface;
using UserRegistration.Infraestructure.Repository;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using UserRegistration.Application;

namespace UserRegistration.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<UserRegistrationDbContext>(op =>
            op.UseSqlServer(Configuration.GetConnectionString("defaultConnection"), sql =>
            sql.MigrationsAssembly("UserRegistration.Api")));

            services.AddSingleton(new AutoMapper.MapperConfiguration(conf => conf.AddProfile(typeof(MapperConfiguration))).CreateMapper());

            services.AddTransient<IRepository<User>, UserRepository>();
            services.AddTransient<IRepository<Department>, DepartmentRepository>();

            services.AddTransient<UserApplication>();
            services.AddTransient<DepartmentApplication>();

            services.AddControllers();
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "Registro de usuarios", Version = "v1" });
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Registro de usuarios v1"));
            }

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
