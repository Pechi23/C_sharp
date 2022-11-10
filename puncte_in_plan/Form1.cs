namespace puncte_in_plan
{
    public partial class Form1 : Form
    {
        Graphics grp;
        Bitmap bmp;
        public static Random rnd = new Random();
        PointF[] p;
        int n = 50;
        public Form1()
        {
            InitializeComponent();
        }

        float distantaE(PointF A, PointF B)
        {
            return (float) Math.Sqrt(Math.Pow(B.X-A.X,2) + Math.Pow(B.Y-A.Y,2));
        }

        float perimetru(PointF A,PointF B, PointF C)
        {
            return distantaE(A,B) + distantaE(A,C) + distantaE(B,C);
        }

        PointF centruDeGreutate(PointF [] p)
        {
            float x = 0;
            float y = 0;
            for (int i = 0; i < p.Length; i++)
            {
                x += p[i].X;
                y += p[i].Y;
            }
            return new PointF(x/p.Length,y/p.Length);
        }

        float det(PointF A, PointF B, PointF C)
        {
            return A.X * B.Y + B.X * C.Y + A.Y * C.X - A.Y * B.X - B.Y * C.X - C.Y * A.X;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            p = new PointF[n];

            for (int i = 0; i < n; i++)
            {
                p[i] = new PointF(rnd.Next(pictureBox1.Width), rnd.Next(pictureBox1.Height));
                grp.DrawEllipse(new Pen(Color.Red), p[i].X-2, p[i].Y-2, 5, 5);     
            }

            //TODO: sa desenam traseul cel mai scurt dintre puncte (folosind metoda greedy)

            int a=0, b=1, c=2;
            int a1 = 0, b1 = 1, c1 = 2;
            float minP = perimetru(p[0], p[1], p[2]);
            float min = 0.5f * Math.Abs(det(p[0], p[1], p[2]));
            for(int i = 0; i < n-2;i++)
            {
                for(int j = i+1;j<n-1;j++)
                {
                    for(int k = j+1;k<n;k++)
                    {
                        float d = 0.5f * Math.Abs(det(p[i], p[j], p[k]));
                        float perim = perimetru(p[i], p[j], p[k]);
                        if(minP> perim)
                        {
                            a1 = i;
                            b1 = j;
                            c1 = k;
                            minP = perim;
                        }
                        if (min > d)
                        {
                            a = i;
                            b = j;
                            c = k;
                            min = d;
                        }
                    }
                }
            }

            PointF g = centruDeGreutate(p);

            grp.DrawEllipse(new Pen(Color.Blue, 3), g.X - 10, g.Y - 10, 21, 21);

            for(int i=0;i<p.Length;i++)
            {
                grp.DrawLine(Pens.Orange, g, p[i]);
            }

            grp.DrawPolygon(new Pen(Color.Red, 3), p);

            grp.DrawLine(Pens.Black, p[a], p[b]);
            grp.DrawLine(Pens.Black, p[c], p[b]);
            grp.DrawLine(Pens.Black, p[c], p[a]);

            grp.DrawLine(Pens.Green, p[a1], p[b1]);
            grp.DrawLine(Pens.Green, p[c1], p[b1]);
            grp.DrawLine(Pens.Green, p[c1], p[a1]);

            pictureBox1.Image = bmp;
        }
    }
}