using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication.DAL
{
    public class DataAccessLayer
    {


            public void PrintAllProductCategory()
            {
                using (SqlConnection connection = ConnectionHandler.GetDatabaseConnection())
                using (SqlCommand command = connection.CreateCommand())

                {
                    command.CommandText = "INSERT INTO [CRONUS Sverige AB$Employee] ([First Name], [Middle Name]) VALUES ('John', 'Smith'), ('Jane', 'Doe')";

                    connection.Open();

                    command.ExecuteNonQuery();

                    connection.Close();
                    connection.Dispose();

                }


            }
        }
    }


