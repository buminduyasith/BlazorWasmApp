using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Persistence;
using Core.Common.Interfaces;

namespace Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {

            //todo
            //services.AddTransient(typeof(IPipelineBehavior<,>), typeof(RequestPreProcessorBehavior<,>));

            // services.AddScoped<ISuperHeroService, SuperHeroService>();

            // var useInMemory = configuration.GetValue<bool>("UseInMemoryDatabase");
            // var useInMemory = configuration.GetSection("UseInMemoryDatabase").Value.ToString

            services.AddScoped<IApplicationDbContext, ApplicationDbContext>();

            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseSqlServer(
                    configuration.GetConnectionString("Default")
                );
                options.EnableSensitiveDataLogging(true);
            });

            return services;
        }
    }
}
