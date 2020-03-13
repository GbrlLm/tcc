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

    }
}
