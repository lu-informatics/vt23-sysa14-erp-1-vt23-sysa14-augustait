﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Web;
using System.Web.Services;
using WebApplication.DAL;

namespace WebApplication
{
    /// <summary>
    /// Summary description for WebApplication
    /// </summary>
    [WebService(Namespace = "http://ics.lu.se")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebApplication : System.Web.Services.WebService
    {

        [WebMethod(Description = "Returns all the NO_ values from the employee table")]
            public List<string> GetAllEmployeeIds()
            {
            List<string> employeeIds = DAL.DataAccessLayer.GetALlEmployeeIds();
                return employeeIds;
            }
        

        [WebMethod(Description = "Returns an employee with the specified id")]

        public Employee GetEmployeeByNo(string no)
        {
            Employee employee = DAL.DataAccessLayer.GetEmployeeByNo(no);
            return employee;
        }

        

        [WebMethod(Description = "Returns the number of all tables in the database! ")]

        public int GetTableCount()
        {
            return DataAccessLayer.TableCount();
        }

        [WebMethod(Description = "Returns the number of all columns in the database! ")]

        public int GetColumnCount()
        {
            return DataAccessLayer.ColumnCount();
        }

        [WebMethod(Description = "Returns the names of all the Primary Keys in the database! ")]
        public List<string> GetPrimaryKeyConstraints()
        {
            return DataAccessLayer.GetPrimaryKeyConstraintNames();
        }


        [WebMethod(Description = "Returns the names of all the Columns in the CRONUS Sverige AB$Item table! ")]
        public List<string> GetItemTableColumnNames()
        {
            return DataAccessLayer.GetItemTableColumnNames();
        }

        [WebMethod(Description = "Create an Employee with this button! ")]
        public void AddEmployee(string no, string firstName, string lastName, string jobTitle, string city)
        {
            try
            {
                
                if (string.IsNullOrWhiteSpace(no) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName) || string.IsNullOrWhiteSpace(jobTitle) || string.IsNullOrWhiteSpace(city))
                {
                    throw new ArgumentException("One or more required fields are missing.");
                }

                Employee employee = new Employee();
                employee.No = no;
                employee.FirstName = firstName;
                employee.LastName = lastName;
                employee.JobTitle = jobTitle;
                employee.City = city;

                DataAccessLayer.CreateEmployee(employee);
                
            }
            catch (Exception ex)
            {
              
                throw new Exception("An error occurred while creating the employee. Please try again later.", ex);
            }
        }

        [WebMethod(Description = "Delete an Employee with this button! ")]
        public void DeleteEmployee(string no)
        {

            DAL.DataAccessLayer.DeleteEmployee(no);
            
        }

        [WebMethod(Description = "Update an Employee with this button! ")]
        public void UpdateEmployee(string no, string firstName, string lastName, string jobTitle, string city)
        {
            Employee employee = new Employee();
            employee.No = no;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.JobTitle = jobTitle;
            employee.City = city;


            DAL.DataAccessLayer.UpdateEmployee(employee);
        }




    
}
}


