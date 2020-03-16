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

        public List<UsuarioModel> getUsuario(string user, string pass)
        {
            string query = "select * from usuario where nm_email = @user and cd_senha = @pass";
            return _applicationContext.ConectarBanco<UsuarioModel>(query.ToString(), new { user, pass });
        }

        public void login(string token, int cd_usuario)
        {
            string query = "update auth set cd_usuario = @cd_usuario where cd_sessionId = @token";
            _applicationContext.ConectarBanco<UsuarioModel>(query.ToString(), new { cd_usuario, token });
        }

        public void logout(string token)
        {
            string query = "delete from auth where cd_sessionId = @token";
            _applicationContext.ConectarBanco<UsuarioModel>(query.ToString(), new { token });
        }
    }
}
