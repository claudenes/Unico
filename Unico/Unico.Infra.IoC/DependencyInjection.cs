using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using Unico.Application.Interfaces;
using Unico.Application.Mappings;
using Unico.Application.Services;
using Unico.Domain.Interfaces;
using Unico.Infra.Data.Context;
using Unico.Infra.Data.Repositories;

namespace Unico.Infra.IoC
{
    public static class DependencyInjection
    {
       
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            ConfigureEntityFrameWork(services);
            services.AddScoped<ITarefaRepository, TarefaRepository>();
            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));

            var myhandlers = AppDomain.CurrentDomain.Load("Unico.Application");

            return services;
        }
        private static void ConfigureEntityFrameWork(this  IServiceCollection services)
        {
            string connectionString = "";

            connectionString = @"Data Source=DESKTOP-OAG94LR\SQLEXPRESS;Initial Catalog=GRUPOUNICO;Integrated Security=True;";

            services.AddDbContext<ApplicationDbContext>(options =>
            {

                options.UseSqlServer(connectionString,
                    b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)); options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

        }
        public static IServiceCollection AddServices(this IServiceCollection services) 
        {
            
            services.AddScoped<ITarefaService, TarefaService>();
            services.AddAutoMapper(typeof(DomainToDtoMappingProfile));
            return services;
        }
    }
    
}
