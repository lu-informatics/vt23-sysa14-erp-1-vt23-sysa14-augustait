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

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string HelloSoap()
        {
            return "Hello Soap";
        }

        [WebMethod(Description = "Here you have the option to create an Employee! ")]

        public string HelloTest()
        {
            return "Hello Test";


        }

        [WebMethod(Description = "Here you have the option to update an Employee ")]

        public string HelloTes()
        {
            return "Hello Test";


        }

        [WebMethod(Description = "Here you have the option to delete an Employee ")]

        public string HelloTe()
        {
            return "Hello Test";


        }

        [WebMethod(Description = "Here you have the option to find an Employee ")]

        public string HelloT()
        {
            return "Hello Test";


        }

        [WebMethod(Description = "Click on this button to view all the names of the columns in the database! ")]

        public string Hello()
        {
            return "Hello Test";


        }

        [WebMethod(Description = "Click on this button to view the total number of tables in the database! ")]

        public string Hell()
        {
            return "Hello Test";


        }

        [WebMethod(Description = "Click on this button to view the total number of columns in the database! ")]

        public string Hel()
        {
            return "Hello Test";


        }

        [WebMethod(Description = "Click on this button to view all the Primary Keys in the database! ")]

        public string Hl()
        {
            return "Hello Test";


        }
    }
}
