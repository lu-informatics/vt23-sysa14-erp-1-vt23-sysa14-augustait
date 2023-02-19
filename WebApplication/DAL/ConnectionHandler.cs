using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication.DAL
{
    public class ConnectionHandler
    {

        public static SqlConnection GetSqlServerConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoDatabaseNAV(5-0)DBConnectionString"].ConnectionString;
            var builder = new SqlConnectionStringBuilder(connectionString);
            var connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }
    }
}



