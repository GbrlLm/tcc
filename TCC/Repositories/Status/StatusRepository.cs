using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using TCC.Common.Context;
using TCC.Models;

namespace TCC.Repositories.Status
{
    public class StatusRepository : IStatusRepository
    {
        private readonly ApplicationContext _applicationContext;

        public StatusRepository(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public List<StatusModel> getAll()
        {
            string query = "select * from status";

           return this._applicationContext.ConectarBanco<StatusModel>(query.ToString(), null);
        }
    }
}
