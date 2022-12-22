using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laborator12_22
{
    public class myPoint
    {
        public double X, Y;
        public myPoint(double X, double Y)
        {
            this.X = X;
            this.Y = Y;
        }

        public void Draw(Color c, int size,Graphics g)
        {
            SolidBrush p = new SolidBrush(c);
            g.FillEllipse(p, (float)X - size, (float)Y - size, 2 * size, 2 * size);
            g.DrawEllipse(Pens.Black, (float)X - size, (float)Y - size, 2 * size, 2 * size);
        }
        
    }
}
