using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Xml.Linq;

namespace WebApplication.DAL
{
    public class DataAccessLayer
    { 
            public static List<Employee> GetEmployees()
            {
                var employees = new List<Employee>();
                using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
                {
                connection.Open();
                string query = "SELECT [No_], [First Name] FROM [CRONUS Sverige AB$Employee] WHERE No_ = 'AB'";
                var command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        var employee = new Employee();
                        employee.No = reader["No_"] as string;
                        employee.FirstName = reader["First Name"] as string;
                      
                        
                        employees.Add(employee);
                    }
                }
                return employees;
            }
        }
}

