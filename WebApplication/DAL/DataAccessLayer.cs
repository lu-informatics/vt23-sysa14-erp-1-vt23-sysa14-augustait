﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Contracts;
using System.EnterpriseServices;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Caching;
using System.Web.Security;
using System.Web.Services.Description;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebApplication.DAL
{
    public class DataAccessLayer
    {
        public static List<string> GetALlEmployeeIds()
        {
            var employeeIds = new List<string>();
            using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
            {
                connection.Open();
                string query = "SELECT [No_] FROM [CRONUS Sverige AB$Employee]";
                var command = new SqlCommand(query, connection);
                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    
                    string employeeId = reader["No_"] as string;
                    employeeIds.Add(employeeId);
                }
            }
            return employeeIds;
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
            
                string query = "INSERT INTO [CRONUS Sverige AB$Employee] ([No_], [First Name], [Last Name], [Job Title], [City]," +
            " [Middle Name], [Initials], [Search Name], [Address 2], [Post Code], " +
            " [County], [Phone No_], [Mobile Phone No_], [Address], [E-Mail], " +
            " [Alt_ Address Code], [Alt_ Address Start Date], [Alt_ Address End Date], [Birth Date], " +
            " [Sex], [Social Security No_], [Picture], [Union Code], [Manager No_], [Union Membership No_], [Extension], [Title], [No_ Series], [Resource No_], " +
            " [Global Dimension 1 Code], [Global Dimension 2 Code], [Termination Date], [Inactive Date], [Employment Date], [Statistics Group Code], " +
            " [Emplymt_ Contract Code], [Status], [Cause of Inactivity Code], [Grounds for Term_ Code], [Last Date Modified], [Pager], [Fax No_], [Company E-Mail], " +
            " [Salespers__Purch_ Code], [Country_Region Code]) " +
         
            " VALUES (@No_, @FirstName, @LastName, @JobTitle, @City, 'AJE', 'AJD', 'AJB', 'AJK', 'AJA'," +
                    " 'AJO', 'AJR', 'HR', 'CRO', 'AJ@gmail.com', 1, '2023-02-16', '2023-02-16', '2023-02-16', 1, 'DA', 'KA', 'HU', 'KO', 'LE', 'PE', 'LA', 'AJÖ', 'AJÄ', 'AJE', 'AJ'," +
                    " '2023-02-16', '2023-02-16', '2023-02-16', 'AJJJJJJ', 1, 1, 1, 1, '2023-02-16', 'AJ', 1, 'AJ', 1, 1)";

                
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

                string query = "UPDATE[CRONUS Sverige AB$Employee] SET [First Name] = @FirstName,  [Last Name] = @LastName,  [Job Title] = @JobTitle,  [City] = @City  WHERE No_ = @No_";
                    var command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@No_", employee.No);
                    command.Parameters.AddWithValue("@FirstName", employee.FirstName);
                    command.Parameters.AddWithValue("@LastName", employee.LastName);
                    command.Parameters.AddWithValue("@JobTitle", employee.JobTitle);
                    command.Parameters.AddWithValue("@City", employee.City);

                    command.ExecuteNonQuery();
                }

            }

       public static bool EmployeeExists(string no)
        {
           using (SqlConnection connection = ConnectionHandler.GetSqlServerConnection())
           {
                connection.Open();

               string query = "SELECT COUNT(*) FROM [CRONUS Sverige AB$Employee] WHERE [No_] = @No_";
               var command = new SqlCommand(query, connection);
               command.Parameters.AddWithValue("@No_", no);

           int count = (int)command.ExecuteScalar();

                return count > 0;
           }
        }


    }
}
    



