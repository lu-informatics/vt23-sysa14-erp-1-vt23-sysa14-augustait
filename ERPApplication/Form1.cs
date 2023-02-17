namespace ERPApplication
{
    public partial class Form1 : Form
    {
        private readonly DataAccessLayer.DataAccessLayer _layer;
        public Form1()
        {
            _layer = new DataAccessLayer.DataAccessLayer();
            InitializeComponent();
        }

        private void buttonCreateEmployee_Click(object sender, EventArgs e)
        {
            _layer.createEmp();
        }
    }
}