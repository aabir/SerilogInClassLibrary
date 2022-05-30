using SeriLogClassLibrary;
using ILogger = Serilog.ILogger;

namespace WinFormsWithSeriLog
{
    public partial class Form1 : Form
    {
        private readonly ILogger _logger;
        public Form1()
        {
            _logger = SerilogTest.GetInstance();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _logger.Information("Serilog from button click");

            MessageBox.Show("Button Clicked");
        }
    }
}