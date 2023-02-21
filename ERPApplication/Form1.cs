using ERPServiceReference;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;
using static ERPServiceReference.WebApplicationSoapClient;
using System.ServiceModel;

namespace ERPApplication
{

    public partial class Form1 : Form
    {

        private readonly WebApplicationSoapClient _webServiceClient;


        public Form1()
        {
            
            InitializeComponent();
           

        }

        private void buttonCreateEmployee_Click(object sender, EventArgs e)
        {
            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);
            List<string> primaryKeyConstraints = webApplication.GetPrimaryKeyConstraints().ToList();

            // Display the result in a message box
            MessageBox.Show($"Primary Key Constraints: {string.Join(", ", primaryKeyConstraints)}");
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

        }


        //private void FindEmployee_Click(object sender, EventArgs e)
        //{
        //    var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
        //    WebApplicationSoapClient webApplication = new(endpointConfiguration);

        //    string employeeNo = textBoxNbr.Text;

        //    // Call the FindEmployeeByNo method in WebApplication to retrieve the employee
        //    Employee employee = webApplication.FindEmployeeByNo(employeeNo);

        //    // Check if the employee exists
        //    if (employee == null)
        //    {
        //        richTextBox.AppendText($"Employee with No. {employeeNo} does not exist. Please try again.\n");
        //    }
        //    else
        //    {
        //        // Display the employee information in the rich text box
        //        richTextBox.AppendText($"No: {employee.No}\n");
        //        richTextBox.AppendText($"First Name: {employee.FirstName}\n");
        //        richTextBox.AppendText($"Last Name: {employee.LastName}\n");
        //        richTextBox.AppendText($"Job Title: {employee.JobTitle}\n");
        //        richTextBox.AppendText($"City: {employee.City}\n");
        //    }
        //}

        private void CreateEmployee_Click(object sender, EventArgs e)
        {

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
