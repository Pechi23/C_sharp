using System.Linq.Expressions;
using System.Security.Cryptography.X509Certificates;

namespace _11_24_laborator
{
    public partial class MainForm : Form
    {
        ListBox listBox;
        int ncs;
        Random rnd = new Random();
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
            listBox = new ListBox();
            listBox.Parent = this;
            listBox.Width = 100;
            listBox.Height = 600;
            listBox.Top = 50;
            listBox.Left = 50;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refresh();
        }

        private void refresh()
        {
            listBox.Items.Add(Engine.x.ToString());
        }

        public int GenerateRandomNumber()
        {
            int x;
            bool ok;
            do
            {
                ok = true;
                x = rnd.Next(1000, 10000);
                int c1 = x % 10, c2 = x / 10 % 10, c3 = x / 100 % 10, c4 = x / 1000;
                if (c1 == c2 || c2 == c3 || c3 == c4 || c1 == c4 || c2 == c4 || c1 == c3)
                    ok = false;
            } while (!ok);
            return x;
        }

        public int GenerateRandomNumber1()
        {
            int c1,c2,c3,c4;
            c1 = rnd.Next(1, 10);
            bool ok;
            do { c2 = rnd.Next(10); }while(c1 == c2);
            do { ok = true; c3 = rnd.Next(10); if (c1 == c3 || c2 == c3) ok = false; }while (!ok);
            do { ok = true; c4 = rnd.Next(10); if (c1 == c4 || c2 == c4 || c3==c4) ok = false; } while (!ok);
            return c1*1000 + c2*100 + c3*10 + c4;
        }

        public int GenerateRandomNumber3()
        {
            List<int> cifre = new List<int>();
            for (int i = 0; i <= 9; i++)
                cifre.Add(i);
            int t = rnd.Next(1, 10);
            int x = cifre[t] * 1000;
            cifre.Remove(cifre[t]);
            t = rnd.Next(cifre.Count);
            x += cifre[t] * 100;
            cifre.Remove(cifre[t]);
            t = rnd.Next(cifre.Count);
            x += cifre[t] * 10;
            cifre.Remove(cifre[t]);
            t = rnd.Next(cifre.Count);
            x += cifre[t];
            cifre.Remove(cifre[t]);
            return x;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = GenerateRandomNumber().ToString();
        }
    }
}