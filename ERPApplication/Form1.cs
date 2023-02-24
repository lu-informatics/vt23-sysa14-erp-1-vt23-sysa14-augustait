using ERPServiceReference;
using System.Data.Common;
using System.Data;
using System.Windows.Forms;
using static ERPServiceReference.WebApplicationSoapClient;
using System.ServiceModel;
using System.Net.Sockets;
using System.Numerics;

namespace ERPApplication
{

    public partial class Form1 : Form
    {

        private readonly WebApplicationSoapClient _webServiceClient;


        public Form1()
        {
            
            InitializeComponent();

            var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
            _webServiceClient = new(endpointConfiguration);

            RefreshComboBox();
            comboBoxEmpId.SelectedIndex = -1;
        }

        private void RefreshComboBox()
        {
            

            // Retrieve the list of employee IDs
            List<string> employeeIds = _webServiceClient.GetAllEmployeeIds();

            // Set the DataSource property of the ComboBox to the list of employee IDs
            comboBoxEmpId.DataSource = employeeIds;
            
        }

        private void CreateEmployee_Click(object sender, EventArgs e)
        {
           
            // Clear selected item in combo box
            comboBoxEmpId.SelectedIndex = -1;
            richTextBox.Text = "";
            string empId = "";

            if (!string.IsNullOrWhiteSpace(comboBoxEmpId.Text))
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
                    Employee existingEmployee = _webServiceClient.GetEmployeeByNo(empId);

                    if (existingEmployee != null)
                    {
                        MessageBox.Show("Employee with ID: " + empId + " already exists!");
                    }
                    else
                    {
                        _webServiceClient.AddEmployee(empId, firstName, lastName, jobTitle, city);
                        MessageBox.Show("Employee with ID: " + empId + " has been added successfully!");
                        RefreshComboBox();
                    }
                }
                catch (System.ServiceModel.FaultException)
                {
                    richTextBox.Text = "An error occurred while calling the web service. Check your connection to the database.";
                }
            }
        }

        private void FindEmployee_Click(object sender, EventArgs e)
        {
            try
            {
                richTextBox.Text = "";
                string employeeNo = "";
                if (comboBoxEmpId.SelectedItem != null)
                {
                    employeeNo = comboBoxEmpId.SelectedItem.ToString();
                }
                else if (!string.IsNullOrWhiteSpace(comboBoxEmpId.Text))
                {
                    employeeNo = comboBoxEmpId.Text;
                }
                else
                {
                    richTextBox.Text = "Please either select or enter an Employee ID to find!";
                    return;
                }

                Employee employee = _webServiceClient.GetEmployeeByNo(employeeNo);

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
                richTextBox.AppendText($"An error occurred while calling the web service. Check your connection to the database. \n");
            }
        }



        private void DeleteEmployee_Click(object sender, EventArgs e)
        {
            comboBoxEmpId.SelectedIndex = -1;
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
                    Employee existingEmployee = _webServiceClient.GetEmployeeByNo(empId);

                    if (existingEmployee == null)
                    {
                        MessageBox.Show("Employee with ID: " + empId + " doesn't exist! Please specify an ID that exists!");
                        comboBoxEmpId.Text = "";
                    }
                    else
                    {
                    _webServiceClient.DeleteEmployee(empId);
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
            comboBoxEmpId.SelectedIndex = -1;
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
                richTextBox.Text = "Please either select or enter an Employee ID to update!";
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
                    Employee existingEmployee = _webServiceClient.GetEmployeeByNo(empId);

                    if (existingEmployee == null)
                    {
                        MessageBox.Show("Employee with ID: " + empId + " doesn't exist! Please specify an ID that exists!");
                        comboBoxEmpId.Text = "";
                    }
                    else
                    {
                        _webServiceClient.UpdateEmployee(empId, firstName, lastName, jobTitle, city);
                        MessageBox.Show("Employee with ID: " + empId + " has been updated successfully!");
                    }
                }
                catch (System.ServiceModel.FaultException)
                {
                    richTextBox.AppendText($"An error occurred while calling the web service. Check your connection to the database. \n");
                }
            }
        }

        private void NamesOfAllColumns_Click(object sender, EventArgs e)
        {
            try
            {
            List<string> columnNames = _webServiceClient.GetItemTableColumnNames().ToList();

            // Add column names to the RichTextBox
            richTextBox.Clear();
            richTextBox.AppendText("Names of all columns in the CRONUS Sverige AB$Item table:\n\n"); 
            foreach (string columnName in columnNames)
            {
                richTextBox.AppendText(columnName + "\n");
            }
            }
            catch (System.ServiceModel.FaultException)
            {
                richTextBox.Text = "An error occurred while calling the web service. Check your connection to the database. ";
            }
        }

        private void AllPrimaryKeys_Click(object sender, EventArgs e)
        {
            try
            {
                
            List<string> constraintNames = _webServiceClient.GetPrimaryKeyConstraints().ToList();

            // Display constraint names in RichTextBox
            richTextBox.Clear();
            richTextBox.Text = "Names of all the primary key constraints in the database: \n\n";
            foreach (string constraintName in constraintNames)
            {
                richTextBox.AppendText(constraintName + "\n");
            }
        }
        catch (System.ServiceModel.FaultException)
            {
                richTextBox.Text = "An error occurred while calling the web service. Check your connection to the database. ";
            }
}
    


        private void TotalNumberOfTables_Click(object sender, EventArgs e)
        {
            try
            {
               
            int tableCount = _webServiceClient.GetTableCount();
            richTextBox.Clear();
            richTextBox.AppendText($"Total number of tables in the database: {tableCount}");

            }
            catch (System.ServiceModel.FaultException)
            {
                richTextBox.Text = "An error occurred while calling the web service. Check your connection to the database. ";
            }
        }


        private void TotalNumberOfColumns(object sender, EventArgs e)
        {
            try
            {
         
            int columnCount = _webServiceClient.GetColumnCount();
            richTextBox.Clear();
            richTextBox.AppendText($"The total number of columns in the database is: {columnCount}\n");
        }
            catch (System.ServiceModel.FaultException)
            {
                richTextBox.Text = "An error occurred while calling the web service. Check your connection to the database. ";
            }
        }
    }
}




