using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Common.Context;
using TCC.Repositories.Status;
using TCC.Services.Status;

namespace TCC.Common.Dependencias
{
    public class NativeInjector
    {
        public static void Registros(IServiceCollection services)
        {
            RegisterRepositories(services);
            RegisterServices(services);
        }

        public static void RegisterRepositories(IServiceCollection services)
        {
            services.AddScoped<EntityContext>();
            services.AddScoped<ApplicationContext>();
            services.AddTransient<IStatusRepository, StatusRepository>();
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IStatusServices, StatusServices>();
        }
    }
}
