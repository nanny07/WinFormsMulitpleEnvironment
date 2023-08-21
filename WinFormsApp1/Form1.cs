using Microsoft.Extensions.Configuration;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private readonly IConfiguration configuration;

        public Form1(IConfiguration configuration)
        {
            InitializeComponent();
            this.configuration = configuration;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = configuration.GetValue<string>("environment");
            label2.Text = configuration.GetValue<string>("common");
        }
    }
}