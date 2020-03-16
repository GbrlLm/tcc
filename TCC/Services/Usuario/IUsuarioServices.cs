using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Services.Usuario
{
    public interface IUsuarioServices
    {
        bool login(string token, string user,string pass);
        void logout(string token);
    }
}
