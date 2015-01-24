using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    class Ellipse : Shape
    {
        public Ellipse(int x, int y) : base(x, y) { }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawEllipse(pen, Math.Min(x1, x2), Math.Min(y1, y2), Math.Abs(x2 - x1), Math.Abs(y2 - y1));
        }
    }
}
