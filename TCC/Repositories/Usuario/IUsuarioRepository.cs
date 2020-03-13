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
        bool login(string token, string user, string pass);
    }
}
