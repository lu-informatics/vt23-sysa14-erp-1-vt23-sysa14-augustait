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
        
public static Employee GetEmployeeByNo(string no)
    {
        Employee employee = null;
        using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
        {
            connection.Open();

            string query = "SELECT [No_], [First Name], [Last Name], [Job Title], [City] FROM [CRONUS Sverige AB$Employee] WHERE No_ = @No_";
            var command = new SqlCommand(query, connection);
            command.Parameters.AddWithValue("@No_", no);

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                employee = new Employee();
                employee.No = reader["No_"] as string;
                employee.FirstName = reader["First Name"] as string;
                employee.LastName = reader["Last Name"] as string;
                employee.JobTitle = reader["Job Title"] as string;
                employee.City = reader["City"] as string;
            }
        }
        return employee;
    }
    }
}


