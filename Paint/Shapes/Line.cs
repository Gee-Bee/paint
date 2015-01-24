using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.Shapes
{
    class Line : Shape
    {
        public Line(int x, int y) : base(x, y) { }

        public override void Draw(Graphics graphics, Pen pen)
        {
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
