using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;
using TCC.Repositories.Usuario;

namespace TCC.Services.Usuario
{
    public class UsuarioServices : IUsuarioServices
    {
        private IUsuarioRepository _usuarioRepository;

        public UsuarioServices(IUsuarioRepository usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public bool login(string user, string pass)
        {
            if (_usuarioRepository.login(user, pass))
            {
                //TODO
            }


            return false;
        }
    }
}
