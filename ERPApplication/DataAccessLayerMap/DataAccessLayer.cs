﻿using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPApplication.DataAccessLayer
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
    
