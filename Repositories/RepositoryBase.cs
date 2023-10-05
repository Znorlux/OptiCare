using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Security.Cryptography;

//Hora de implementar la DB
namespace OptiCare.Repositories
{
    public abstract class RepositoryBase
    {
        private readonly string _connectionString;
        private object _serverName;

        public RepositoryBase()
        {
            _serverName = "ZNORLUX-DESKTOP\\SQLEXPRESS";
            _connectionString = $"Server={_serverName}; Database=OptiCare; Integrated Security=true";

        }
        protected SqlConnection GetConnection() { 
            return new SqlConnection(_connectionString);
        }
    }
}
