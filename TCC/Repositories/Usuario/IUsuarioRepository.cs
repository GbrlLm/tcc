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
        List<UsuarioModel> getUsuarioByEmail(string email);
        void login(string token, int cd_usuario);
        void logout(string token);
        void createUser(string pass, string email, string cpf, string nome, string sobrenome, DateTime nasc, string sexo);
        bool isEmailOrCpfInUse(string email, string cpf);
    }
}
