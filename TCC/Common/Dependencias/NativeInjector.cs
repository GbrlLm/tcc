using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
            //services.AddTransient<IUsuarioRepository, UsuarioRepository>();
        }

        public static void RegisterServices(IServiceCollection services)
        {
            //services.AddScoped<IUsuarioService, UsuarioService>();
            //services.AddScoped<IServiceResponse, ServiceResponse>();
        }
    }
}
