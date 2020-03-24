using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Common.Context;
using TCC.Models;

namespace TCC.Repositories.Usuario
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly ApplicationContext _applicationContext;
        private readonly EntityContext _entityContext;

        public UsuarioRepository(ApplicationContext applicationContext, EntityContext entityContext)
        {
            _applicationContext = applicationContext;
            _entityContext = entityContext;
        }

        public bool verifyToken(string token)
        {
            string query = "select cd_sessionId from auth where cd_sessionId = @token and cd_usuario is null";
            return _applicationContext.ConectarBanco<AuthModel>(query.ToString(), new { token }).Any();
        }

        public List<UsuarioModel> getUsuarioByEmail(string email)
        {
            string query = "select * from usuario where nm_email = @email";
            return _applicationContext.ConectarBanco<UsuarioModel>(query.ToString(), new { email });
        }

        public void login(string token, int cd_usuario)
        {
            string query = "update auth set cd_usuario = @cd_usuario where cd_sessionId = @token";
            _applicationContext.ConectarBanco<int>(query.ToString(), new { cd_usuario, token });
        }

        public void logout(string token)
        {
            string query = "delete from auth where cd_sessionId = @token";
            _applicationContext.ConectarBanco<int>(query.ToString(), new { token });
        }

        public void createUser(string pass, string email, string cpf, string nome, string sobrenome, DateTime nasc, string sexo)
        {
            string query = "insert into usuario" +
                "(cd_senha, nm_email, cd_cpf, nm_usuario, nm_sobrenome, dt_nascimento, ic_sexo) values" +
                "(@pass, @email, @cpf, @nome, @sobrenome, @nasc, @sexo);";
            _applicationContext.ConectarBanco<int>(query.ToString(), new { pass, email, cpf, nome, sobrenome, nasc, sexo });
        }

        public bool isEmailOrCpfInUse(string email, string cpf)
        {
            string query = "select * from usuario where cd_cpf = @cpf or nm_email = @email";
            return _applicationContext.ConectarBanco<UsuarioModel>(query.ToString(), new { email, cpf }).Any();
        }
    }
}
