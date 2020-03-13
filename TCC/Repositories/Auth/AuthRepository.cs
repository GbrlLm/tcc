using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Common.Context;
using TCC.Models;

namespace TCC.Repositories.Auth
{
    public class AuthRepository : IAuthRepository
    {
        private readonly ApplicationContext _applicationContext;
        private readonly EntityContext _entityContext;

        public AuthRepository(ApplicationContext applicationContext, EntityContext entityContext)
        {
            _applicationContext = applicationContext;
            _entityContext = entityContext;
        }

        public void generateSessionId(string token)
        {
            string query = "insert into auth(cd_sessionId) values(@token)";

            _applicationContext.ConectarBanco<int>(query.ToString(), new { token });
        }
    }
}
