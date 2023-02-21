using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public static int TableCount()
        {
            int count = 0;
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();
                string query = "SELECT COUNT(*) FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_TYPE='BASE TABLE'";
                var command = new SqlCommand(query, connection);
                count = (int)command.ExecuteScalar();
            }
            return count;
        }

        public static int ColumnCount()
        {
            int count = 0;
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();
                string query = "SELECT SUM(column_count) FROM (SELECT COUNT(*) as column_count FROM INFORMATION_SCHEMA.COLUMNS GROUP BY TABLE_NAME) as column_counts";
                var command = new SqlCommand(query, connection);
                count = (int)command.ExecuteScalar();
            }
            return count;
        }

        public static List<string> GetPrimaryKeyConstraintNames()
        {
            List<string> constraintNames = new List<string>();
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();
                string query = "SELECT CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS WHERE CONSTRAINT_TYPE = 'PRIMARY KEY'";
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    constraintNames.Add(reader["CONSTRAINT_NAME"].ToString());
                }
            }
            return constraintNames;
        }

        public static List<string> GetItemTableColumnNames()
        {
            List<string> columnNames = new List<string>();
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();
                string query = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Item'";
                var command = new SqlCommand(query, connection);
                var reader = command.ExecuteReader();
                while (reader.Read())
                {
                    columnNames.Add(reader["COLUMN_NAME"].ToString());
                }
            }
            return columnNames;
        }



        public static void CreateEmployee(Employee employee)
        {
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "INSERT INTO [CRONUS Sverige AB$Employee] ([No_], [First Name], [Last Name], [Job Title], [City]) VALUES (@No_, @FirstName, @LastName, @JobTitle, @City)";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@No_", employee.No);
                command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                command.Parameters.AddWithValue("@LastName", employee.LastName);
                command.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
                command.Parameters.AddWithValue("@City", employee.City);

                command.ExecuteNonQuery();
            }

        }
        public static void DeleteEmployee(string no)
        {
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();

                string query = "DELETE FROM [CRONUS Sverige AB$Employee] WHERE [No_] = @No_";
                var command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@No_", no);


                command.ExecuteNonQuery();

            }
        }

        public static void UpdateEmployee(Employee employee)
            {
                using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
                {
                    connection.Open();

                string query = "UPDATE[CRONUS Sverige AB$Employee] SET[First Name] = @FirstName, [Last Name] = @LastName,  [Job Title] = @JobTitle,  [City] = @City  WHERE No_ = @No_";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@No_", employee.No);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
                    command.Parameters.AddWithValue("@City", employee.City);

                    command.ExecuteNonQuery();
                }

            }


        }
}
    



