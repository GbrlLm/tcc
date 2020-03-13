using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Common.Context;
using TCC.Repositories.Status;
using TCC.Services.Status;
using TCC.Repositories.Auth;
using TCC.Services.Auth;
using TCC.Repositories.Usuario;
using TCC.Services.Usuario;

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
            services.AddTransient<IAuthRepository, AuthRepository>();
            services.AddTransient<IUsuarioRepository, UsuarioRepository>();
        }

        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IStatusServices, StatusServices>();
            services.AddScoped<IAuthServices, AuthServices>();
            services.AddScoped<IUsuarioServices, UsuarioServices>();
        }
    }
}
