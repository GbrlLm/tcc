using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;
using TCC.Models.temp;
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
                List<UsuarioModel> usuario = _usuarioRepository.getUsuario(user, pass);
                if (usuario.Any())
                {
                    _usuarioRepository.login(token, usuario.First().cd_usuario);
                    return true;
                }
            }
            return false;
        }

        public void logout(string token)
        {
            _usuarioRepository.logout(token);
        }

        public bool signUp(SignUp v)
        {
            if (!_usuarioRepository.isEmailOrCpfInUse(v.email, v.cpf))
            {
                _usuarioRepository.createUser(v.pass, v.email, v.cpf, v.nome, v.sobrenome, v.nasc, v.sexo);
                return true;
            }
            return false;
        }
    }
}
