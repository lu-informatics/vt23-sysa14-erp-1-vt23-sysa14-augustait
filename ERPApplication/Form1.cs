using ERPServiceReference;
using System.Windows.Forms;

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

        // DELETE Employee
        private void DeleteEmployee_click(object sender, EventArgs e)
        {
            try
            {
                // Get the ID of the employee to be deleted from the user through the GUI
                string employeeId = textBoxNbr.Text;

                // Call the DeleteEmployee web method of the Web Service
                var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
                WebApplicationSoapClient webApplication = new(endpointConfiguration);
                webApplication.DeleteEmployee(employeeId);

                // Display a success message to the user
                MessageBox.Show("Employee deleted successfully.");
            }
            catch (System.ServiceModel.FaultException ex)
            {
                if (ex.Message.Contains("Violation of PRIMARY KEY constraint"))
                {
                    MessageBox.Show("Error deleting employee: The employee ID does not exist.");
                }
                else
                {
                    MessageBox.Show("Error deleting employee: " + ex.Message);
                }
            }
        }

        // FIND Employee
        //private void FindEmployee_Click(object sender, EventArgs e)
        //{
        //    try
        //    {
        //        string employeeId = textBoxNbr.Text;
        //        var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
        //        WebApplicationSoapClient webApplication = new(endpointConfiguration);
        //        Employee employee = webApplication.FindEmployeeByNo(employeeId);

        //        if (employee != null)
        //        {
        //            textBoxFirstName.Text = employee.FirstName;
        //            textBoxLastName.Text = employee.LastName;
        //            textBoxJobTitle.Text = employee.JobTitle;
        //            textBoxCity.Text = employee.City;
        //        }
        //        else
        //        {
        //            MessageBox.Show("Employee not found.");
        //        }
        //    }
        //    catch (System.ServiceModel.FaultException ex)
        //    {
        //        MessageBox.Show("Error finding employee: " + ex.Message);
        //    }
        //}

        private void UpdateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void CreateEmployee_Click(object sender, EventArgs e)
        {

        }

        private void NamesOfAllColumns_Click(object sender, EventArgs e)
        {

        }

        private void TotalNumberOf_Click(object sender, EventArgs e)
        {

        }

        private void AllPrimaryKeys_Click(object sender, EventArgs e)
        {

        }
    }
    }
