using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPApplication.DataAccessLayer
{
    public class ConnectionHandler
    {
            public static SqlConnection GetSqlServerConnection()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DemoDatabaseNAV(5-0)ConnectionStrings"].ConnectionString;
                var builder = new SqlConnectionStringBuilder(connectionString);
                var connection = new SqlConnection(builder.ConnectionString);
                return connection;
            }
        }

    }

