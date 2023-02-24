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

            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);

            RefreshComboBox();
        }

        private void RefreshComboBox()
        {
            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);

            // Retrieve the list of employee IDs
            List<string> employeeIds = webApplication.GetAllEmployeeIds();

            // Set the DataSource property of the ComboBox to the list of employee IDs
            comboBoxEmpId.DataSource = employeeIds;
        }


        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);

            richTextBox.Text = "";
            string empId = "";

            if (comboBoxEmpId.SelectedItem != null)
            {
                empId = comboBoxEmpId.SelectedItem.ToString();
            }
            else if (!string.IsNullOrWhiteSpace(comboBoxEmpId.Text))
            {
                empId = comboBoxEmpId.Text;
            
         }
             else
              {
                  richTextBox.Text = "Please either select or enter an Employee ID to remove!";
                   return;
                 }

    
                try
                {
                    Employee existingEmployee = webApplication.GetEmployeeByNo(empId);

                    if (existingEmployee == null)
                    {
                        MessageBox.Show("Employee with ID: " + empId + " doesn't exist! Please specify an ID that exists!");
                        comboBoxEmpId.Text = "";
                    }
                    else
                    {
                        webApplication.DeleteEmployee(empId);
                        MessageBox.Show("Employee with ID: " + empId + " has been deleted successfully!");
                        RefreshComboBox();
                    }
                }
                catch (System.ServiceModel.FaultException)
                {
                    richTextBox.AppendText($"An error occurred while calling the web service. Check your connection to the database. \n");
                }
            }

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {
            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            WebApplicationSoapClient webApplication = new(endpointConfiguration);

            richTextBox.Text = "";
            string empId = "";

            if (comboBoxEmpId.SelectedItem != null)
            {
                empId = comboBoxEmpId.SelectedItem.ToString();
            }
            else if (!string.IsNullOrWhiteSpace(comboBoxEmpId.Text))
            {
                empId = comboBoxEmpId.Text;
            }
            else
            {
                richTextBox.Text = "Please select or enter an Employee ID to update!";
                return;
            }

            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;
            string jobTitle = textBoxJobTitle.Text;
            string city = textBoxCity.Text;

            if (string.IsNullOrWhiteSpace(firstName) || string.IsNullOrWhiteSpace(lastName)
                || string.IsNullOrWhiteSpace(jobTitle) || string.IsNullOrWhiteSpace(city))
            {
                richTextBox.Text = "Please enter all the fields!";
            }
            else
            {
                try
                {
                    Employee existingEmployee = webApplication.GetEmployeeByNo(empId);

                    if (existingEmployee == null)
                    {
                        MessageBox.Show("Employee with ID: " + empId + " doesn't exist! Please specify an ID that exists!");
                        comboBoxEmpId.Text = "";
                    }
                    else
                    {
                        webApplication.UpdateEmployee(empId, firstName, lastName, jobTitle, city);
                        MessageBox.Show("Employee with ID: " + empId + " has been updated successfully!");
                    }
                }
                catch (System.ServiceModel.FaultException)
                {
                    richTextBox.AppendText($"An error occurred while calling the web service. Check your connection to the database. \n");
                }
            }
        }


        private void FindEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Text = "";
                var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
                WebApplicationSoapClient webApplication = new(endpointConfiguration);

                string employeeNo = "";
                if (comboBoxEmpId.SelectedItem == null || string.IsNullOrWhiteSpace(comboBoxEmpId.Text))
                {
                    richTextBox.Text = "Please select an employee ID or type one to find!";
                    return;
                }
                else if (comboBoxEmpId.SelectedItem != null)
                {
                    employeeNo = comboBoxEmpId.SelectedItem.ToString();
                }
                else if (!string.IsNullOrWhiteSpace(comboBoxEmpId.Text))
                {
                    employeeNo = comboBoxEmpId.Text;
                }

                Employee employee = webApplication.GetEmployeeByNo(employeeNo);

                if (employee == null)
                {
                    richTextBox.AppendText($"Employee with No. {employeeNo} does not exist. Please try again.\n");
                }
                else
                {
                    richTextBox.AppendText("No: " + employee.No + "\n");
                    richTextBox.AppendText("First Name: " + employee.FirstName + "\n");
                    richTextBox.AppendText($"Last Name: {employee.LastName}\n");
                    richTextBox.AppendText($"Job Title: {employee.JobTitle}\n");
                    richTextBox.AppendText($"City: {employee.City}\n");
                }
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
            string empId = "";

            if (comboBoxEmpId.SelectedItem != null)
            {
                empId = comboBoxEmpId.SelectedItem.ToString();
            }
            else if (!string.IsNullOrWhiteSpace(comboBoxEmpId.Text))
            {
                empId = comboBoxEmpId.Text;
            }

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
                    
                    Employee existingEmployee = webApplication.GetEmployeeByNo(empId);

                    if (existingEmployee != null)
                    {
                        MessageBox.Show("Employee with ID: " + empId + " already exists!");
                    }
                    else
                    {
                        webApplication.AddEmployee(empId, firstName, lastName, jobTitle, city);
                        MessageBox.Show("Employee with ID: " + empId + " has been added successfully!");
                        RefreshComboBox();

                    }
                }
                catch (System.ServiceModel.FaultException)
                { 
                    richTextBox.Text = "An error occurred while calling the web service. Check your connection to the database. ";
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
    }
}




