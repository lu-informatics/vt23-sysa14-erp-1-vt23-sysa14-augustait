using ERPServiceReference;
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

        private void DeleteEmployee_click(object sender, EventArgs e)
        {
            try
            {
                string employeeId = textBoxNbr.Text;


                // Call the DeleteEmployee web method of the Web Service
                var endpointConfiguration = WebApplicationSoapClient.EndpointConfiguration.WebApplicationSoap;
                WebApplicationSoapClient webApplication = new(endpointConfiguration);
                webApplication.DeleteEmployee(employeeId);

                // Display a success message to the user
                MessageBox.Show("Employee deleted successfully.");
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during the deletion process
                MessageBox.Show("Error deleting employee: " + ex.Message);
            }
        }

        private void FindEmployee_click(object sender, EventArgs e)
        {

        }

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
