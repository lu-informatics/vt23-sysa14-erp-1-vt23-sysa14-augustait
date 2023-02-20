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









    }
    }
