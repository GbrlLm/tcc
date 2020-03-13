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

        public bool login(string token, string user, string pass)
        {
            string query = "select * from usuario where (nm_usuario = @user or nm_email = @user) and cd_senha = @pass";
            List<UsuarioModel> usuario = _applicationContext.ConectarBanco<UsuarioModel>(query.ToString(), new { user, pass });

            if (usuario.Any())
            {
                query = "update auth set cd_usuario = @cd_usuario where cd_sessionId = @token";
                _applicationContext.ConectarBanco<UsuarioModel>(query.ToString(), new { @cd_usuario = usuario.First().cd_usuario, token });
                return true;
            }

            return false;
        }
    }
}
