using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication
{
    public class Employee
    {
        private string no;
        private string firstName;
        private string lastName;
        private string jobTitle;
        private string city;

        public string No
        {
            get { return no; }
            set { no = value; }
        }

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string JobTitle
        {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        public string City
        {
            get { return city; }
            set { city = value; }
        }
    }
}

   