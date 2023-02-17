using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERPApplication.DataAccessLayer
{
   public class DataAccessLayer
    {
        

    public void createEmp()
    {
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();
                
        
            string query = "INSERT INTO [CRONUS Sverige AB$Employee] ([First Name], [Middle_Name]) VALUES ('John', 'Smith'), ('Jane', 'Doe')";
                using (SqlCommand command = new SqlCommand(query, connection))


                    command.ExecuteNonQuery();
               
            }
    }
}
}