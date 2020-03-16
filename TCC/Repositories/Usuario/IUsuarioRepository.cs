using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Repositories.Usuario
{
    public interface IUsuarioRepository
    {
        bool verifyToken(string token);
        List<UsuarioModel> getUsuario(string user, string pass);
        void login(string token, int cd_usuario);
        void logout(string token);
    }
}
