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

        public void Draw(Color t,myPoint[] v)
        {
            /*
            for(int i=0;i<v.Length-1;i++)
            {
                g.DrawLine(new Pen(Color.FromArgb(100, 100, 100)), (float)v[i].X, (float)v[i].Y, (float)v[i + 1].X, (float)v[i + 1].Y);
            }
            g.DrawLine(new Pen(Color.FromArgb(100, 100, 100)), (float)v[0].X, (float)v[0].Y, (float)v[v.Length-1].X, (float)v[v.Length-1].Y);
            */
            for (int i = 0; i < v.Length; i++)
                g.DrawLine(new Pen(t), (float)v[i].X, (float)v[i].Y, (float)v[(i + 1)%v.Length].X, (float)v[(i + 1)%v.Length].Y);

            for (int i = 0; i < v.Length; i++)
                v[i].Draw(Color.Red, 2, g);
        }

        public myPoint[] SP(myPoint[] v)
        {
            myPoint[] ret = new myPoint[v.Length];

            for(int i=0;i<v.Length;i++)
            {
                double x = (v[i].X + v[(i + 1) % v.Length].X) / 2;
                double y = (v[i].Y + v[(i + 1) % v.Length].Y) / 2;
                ret[i] = new myPoint(x, y);
            }

            return ret;
        }

        public myPoint G(myPoint[] v)
        {
            double x = 0;
            double y = 0;
            for(int i=0;i<v.Length;i++)
            {
                x += v[i].X;
                y += v[i].Y;
            }
            return new myPoint(x / v.Length, y / v.Length);
        }

        public double Determinant(myPoint a,myPoint b, myPoint c)
        {
            return a.X * b.Y + b.X * c.Y + c.X * a.Y - c.X * b.Y - a.X * c.Y - b.X * a.Y;
        }

        public double AriePoligon(myPoint[] v)
        {
            double arie = 0;

            for(int i=0;i<v.Length;i++)
                arie += Determinant(v[i], v[(i + 1) % v.Length], new myPoint(0, 0)) / 2;

            return Math.Abs(arie);
        }

        void Rec(myPoint[] v)
        {
            if(AriePoligon(v)>1)
            {
                Draw(Color.Red, v);
                v = SP(v);               
                Rec(v);
            }
        }

        public double DistantaE(myPoint a, myPoint b)
        {
            return Math.Sqrt((a.X - b.X) * (a.X - b.X) + (a.Y - b.Y) * (a.Y - b.Y));
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            b = new Bitmap(display.Width, display.Height);
            g = Graphics.FromImage(b);
            p = new myPoint[100];

            for(int i=0;i<p.Length;i++)
                p[i] = new myPoint(rnd.Next(display.Width), rnd.Next(display.Height));

            Draw(Color.Green,p);
            myPoint cg = G(p);
            cg.Draw(Color.Orange, 4, g);

            Rec(p);

            myPoint newCg = G(p);
            double rez = DistantaE(cg, newCg);


            textBox1.Text = rez.ToString();


            display.Image = b;
        }
    }
}