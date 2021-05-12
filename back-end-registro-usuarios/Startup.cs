using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using UserRegistration.Api.MapConfiguration;
using UserRegistration.Application;
using UserRegistration.Domain.Entites;
using UserRegistration.Infraestructure.DataAccess;
using UserRegistration.Infraestructure.Insterface;
using UserRegistration.Infraestructure.Repository;

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
            services.AddCors(setupAction =>
            {
                setupAction.AddDefaultPolicy(policy =>
                {
                    policy
                    .WithOrigins(new string[] { "http://localhost:43336/api/user" })
                    .WithHeaders(new string[] { "Accept", "Content-Type", "Access-Control-Allow-Origin" })
                    .WithMethods(new string[] { "HttpPost", "HttpGet", "HttpPut", "HttpPatch" });
                });
            });

            services.AddDbContext<UserRegistrationDbContext>(op =>
            op.UseSqlServer(Configuration.GetConnectionString("HomeConnection"), sql =>
            //op.UseSqlServer(Configuration.GetConnectionString("JobConnection"), sql =>
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

            app.UseCors();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
