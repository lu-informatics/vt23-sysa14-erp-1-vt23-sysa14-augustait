using System;
using System.Collections.Generic;
using System.Linq;
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
            Employee employee = new Employee();
            employee.No = no;
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.JobTitle = jobTitle;
            employee.City = city;

            DAL.DataAccessLayer.CreateEmployee(employee);
        }

        [WebMethod(Description = "Delete an Employee with this button! ")]
        public void DeleteEmployee (string no)
        {
            

         DAL.DataAccessLayer.DeleteEmployee(no);
           

        }


}
}

