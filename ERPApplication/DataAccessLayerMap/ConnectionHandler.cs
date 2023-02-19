using System.Data.SqlClient;
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

       
            public static SqlConnection GetDatabaseConnection()
            {
                string connectionString = ConfigurationManager.ConnectionStrings["DemoDatabaseNAV(5-0)DBConnectionString"].ConnectionString;
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionString);
                SqlConnection connection = new SqlConnection(builder.ConnectionString);
                return connection;
            }
        }
    }

    



