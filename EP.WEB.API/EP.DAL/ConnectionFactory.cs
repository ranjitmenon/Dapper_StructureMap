using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EP.DAL
{
    public class SqlConnectionFactory : IConnectionFactory
    {
        static string ConnectionString => ConfigurationManager.ConnectionStrings["EpDB"].ConnectionString;
        public IDbConnection GetConnection()
        {
            return new SqlConnection(ConnectionString);
        }
    }
}
