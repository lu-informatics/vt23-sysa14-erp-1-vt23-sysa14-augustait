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

        public static SqlConnection GetDatabaseConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DemoDatabaseNAV(5-0)DBConnectionString"].ConnectionString;
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
            SqlConnection connection = new SqlConnection(builder.ConnectionString);
            return connection;
        }
    }
}

    
