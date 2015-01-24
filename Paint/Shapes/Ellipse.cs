using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Shapes
{
    class Ellipse : Shape
    {
        private int r1;
        private int r2;

        public Ellipse(int x, int y) : base(x, y) { }

        public override void Draw(Graphics graphics, Pen pen)
        {
            if (stillDrawing)
            {
                r1 = Math.Abs(x2 - x1);
                r2 = Math.Abs(y2 - y1);
                if (Control.ModifierKeys == Keys.Alt)
                {
                    r1 = r2 = Math.Max(r1, r2);
                }
                if (Control.ModifierKeys == Keys.Control)
                {
                    r1 = r1 / 10 * 10;
                    r2 = r2 / 10 * 10;
                }
            }
            graphics.DrawEllipse(pen, Math.Min(x1, x2), Math.Min(y1, y2), r1, r2);
        }
    }
}
