using Dapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TCC.Models;

namespace TCC.Common.Context
{
    public class ApplicationContext
    {
        public readonly string _connectionString;

        public ApplicationContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("Default");
        }

        public List<T> ConectarBanco<T>(string query, Object parametros)
        {
            using (MySqlConnection connect = new MySqlConnection(_connectionString))
            {
                try
                {
                    connect.Open();
                    return connect.Query<T>(query, parametros).ToList();
                }
                catch (Exception e)
                {
                    throw e;
                }
                finally
                {
                    connect.Close();
                }
            }
        }
    }
}
