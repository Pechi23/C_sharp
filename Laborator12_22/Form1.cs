namespace Laborator12_22
{
    
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        Graphics g;
        Bitmap b;
        myPoint[] p;
        public Form1()
        {
            InitializeComponent();
        }

        public void Draw(myPoint[] v)
        {
            /*
            for(int i=0;i<v.Length-1;i++)
            {
                g.DrawLine(new Pen(Color.FromArgb(100, 100, 100)), (float)v[i].X, (float)v[i].Y, (float)v[i + 1].X, (float)v[i + 1].Y);
            }
            g.DrawLine(new Pen(Color.FromArgb(100, 100, 100)), (float)v[0].X, (float)v[0].Y, (float)v[v.Length-1].X, (float)v[v.Length-1].Y);
            */
            for (int i = 0; i < v.Length; i++)
                g.DrawLine(new Pen(Color.FromArgb(100, 100, 100)), (float)v[i].X, (float)v[i].Y, (float)v[(i + 1)%v.Length].X, (float)v[(i + 1)%v.Length].Y);
            

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(display.Width, display.Height);
            g = Graphics.FromImage(b);
            p = new myPoint[10];

            for(int i=0;i<p.Length;i++)
                p[i] = new myPoint(rnd.Next(display.Width), rnd.Next(display.Height));

            Draw(p);


            display.Image = b;
        }
    }
}