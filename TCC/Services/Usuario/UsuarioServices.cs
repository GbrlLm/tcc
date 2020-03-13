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

        public bool login(string token, string user, string pass)
        {
            if (_usuarioRepository.verifyToken(token))
            {
                return _usuarioRepository.login(token, user, pass);
            }

            return false;
        }
    }
}
