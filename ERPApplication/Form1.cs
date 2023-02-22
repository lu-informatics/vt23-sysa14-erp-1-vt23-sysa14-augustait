using ERPServiceReference;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;
using static ERPServiceReference.WebApplicationSoapClient;
using System.ServiceModel;
using System.Net.Sockets;

namespace ERPApplication
{

    public partial class Form1 : Form
    {

        private readonly WebApplicationSoapClient _webServiceClient;


        public Form1()
        {
            
            InitializeComponent();
           

        }

      
        


      
        

        private void button8_Click(object sender, EventArgs e)
        {

        }

        // DELETE Employee - HAR INGEN REFERENS
      
        //private void DeleteEmployee_Click(object sender, EventArgs e)
        //{
        //    var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
        //    WebApplicationSoapClient webApplication = new(endpointConfiguration);

        //    string employeeNo = textBoxNbr.Text;

        //    // Check if employee exists before deleting
        //    bool employeeExists = webApplication.EmployeeExists(employeeNo);
           
        //    if (!employeeExists)
        //    {
        //        richTextBox.AppendText($"Employee with No. {employeeNo} does not exist. Please try again.\n");
        //        return;
        //    }

        //    webApplication.DeleteEmployee(employeeNo);
        //    richTextBox.AppendText($"Employee with No. {employeeNo} has been deleted successfully.\n");
        //}

        // FIND Employee
       

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {

            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);

            richTextBox.Text = "";
            string empId = textBoxNbr.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string jobTitle = textBoxJobTitle.Text;
            string city = textBoxCity.Text;

            if (string.IsNullOrWhiteSpace(empId) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)
                || string.IsNullOrWhiteSpace(jobTitle) || string.IsNullOrWhiteSpace(city))
            {
                richTextBox.Text = "Please enter all the fields!";
            }
            else
            {


               
                    webApplication.UpdateEmployee(empId, firstName, lastName, jobTitle, city);
                    MessageBox.Show("Employee with ID: " + empId + " has been added successfully!");
                
                
        }


    }




        private void FindEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Text = "";
                var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
                WebApplicationSoapClient webApplication = new(endpointConfiguration);

                string employeeNo = textBoxNbr.Text;

                Employee employee = webApplication.GetEmployeeByNo(employeeNo);

                if (employee == null)
                {
                    richTextBox.AppendText($"Employee with No. {employeeNo} does not exist. Please try again.\n");
                }
                else
                {
                    richTextBox.AppendText("No: " + employee.No + "\n");
                    richTextBox.AppendText("First Name: " + employee.No + "\n");
                    richTextBox.AppendText($"Last Name: {employee.LastName}\n");
                    richTextBox.AppendText($"Job Title: {employee.JobTitle}\n");
                    richTextBox.AppendText($"City: {employee.City}\n");
                }
            }
            catch (System.Net.WebException ex)
            {
                // Handle the WebException here
                richTextBox.AppendText($"An error occurred while connecting to the server. Check your network settings. \n");
            }
            catch (System.ServiceModel.FaultException ex)
            {
                // Handle the FaultException here
                richTextBox.AppendText($"An error occurred while calling the web service. Check your connection to the database. \n");
            }
        }

        private void CreateEmployee_Click(object sender, EventArgs e)
        {
            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);

            richTextBox.Text = "";
            string empId = textBoxNbr.Text;
            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string jobTitle = textBoxJobTitle.Text;
            string city = textBoxCity.Text;

            if (string.IsNullOrWhiteSpace(empId) || string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)
                || string.IsNullOrWhiteSpace(jobTitle) || string.IsNullOrWhiteSpace(city))
            {
                richTextBox.Text = "Please enter all the fields!";
            }
            else
            {


                try
                {
                    webApplication.AddEmployee(empId, firstName, lastName, jobTitle, city);
                    MessageBox.Show("Employee with ID: " + empId + " has been added successfully!");
                }
                catch (SocketException ex)
                {
                    MessageBox.Show($"An error occurred while trying to connect to the server: {ex.Message}");
                }

            }
        }

    

private void NamesOfAllColumns_Click(object sender, EventArgs e)
        {
            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);
            List<string> columnNames = webApplication.GetItemTableColumnNames().ToList();

            // Add column names to the RichTextBox
            richTextBox.Clear();
            richTextBox.AppendText("Names of all columns in the CRONUS Sverige AB$Item table:\n\n"); 
            foreach (string columnName in columnNames)
            {
                richTextBox.AppendText(columnName + "\n");
            }
        }

        private void AllPrimaryKeys_Click(object sender, EventArgs e)
        {
            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);
            List<string> constraintNames = webApplication.GetPrimaryKeyConstraints().ToList();

            // Display constraint names in RichTextBox
            richTextBox.Clear();
            richTextBox.Text = "Names of all the primary key constraints in the database: \n\n";
            foreach (string constraintName in constraintNames)
            {
                richTextBox.AppendText(constraintName + "\n");
            }
        }


        private void TotalNumberOfTables_Click(object sender, EventArgs e)
        {
            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new WebApplicationSoapClient(endpointConfiguration);

            int tableCount = webApplication.GetTableCount();
            richTextBox.Clear();
            richTextBox.AppendText($"Total number of tables in the database: {tableCount}");
        }

        private void TotalNumberOfColumns(object sender, EventArgs e)
        {
            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);

            int columnCount = webApplication.GetColumnCount();
            richTextBox.Clear();
            richTextBox.AppendText($"The total number of columns in the database is: {columnCount}\n");
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

    }
    }
