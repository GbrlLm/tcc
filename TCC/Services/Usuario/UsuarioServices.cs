using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                List<UsuarioModel> usuario = _usuarioRepository.getUsuarioByEmail(user);
                if (usuario.Any())
                {
                    UsuarioModel u = usuario.First();
                    byte[] salt = GetSaltFromHashedPassword(u.cd_senha);
                    if (u.cd_senha.Equals(HashPassword(pass, salt)))
                    {
                        _usuarioRepository.login(token, u.cd_usuario);
                        return true;
                    }
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
                byte[] salt = new byte[16];
                new RNGCryptoServiceProvider().GetBytes(salt);

                string pass = HashPassword(v.pass, salt);

                _usuarioRepository.createUser(pass, v.email, v.cpf, v.nome, v.sobrenome, v.nasc, v.sexo);
                return true;
            }
            return false;
        }

        public string HashPassword(string pass, byte[] salt)
        {
            byte[] hash = new Rfc2898DeriveBytes(pass, salt, 1000).GetBytes(32);
            byte[] _pass = new byte[48];
            salt.CopyTo(_pass, 0);
            hash.CopyTo(_pass, 16);

            return Convert.ToBase64String(_pass);
        }

        public byte[] GetSaltFromHashedPassword(string pass)
        {
            byte[] hash = Convert.FromBase64String(pass);
            byte[] salt = new byte[16];
            Array.Copy(hash, 0, salt, 0, 16);

            return salt;
        }
    }
}
