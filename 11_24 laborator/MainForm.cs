namespace _11_24_laborator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void input_Click(object sender, EventArgs e)
        {
            InputForm f2 = new InputForm();
            f2.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}