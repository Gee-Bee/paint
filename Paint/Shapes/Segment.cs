using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Shapes
{
    class Segment : Shape
    {
        public Segment(int x, int y, Pen pen) : base(x, y, pen) { }

        public override void Draw(Graphics graphics)
        {
            if (stillDrawing)
            {
                if (Control.ModifierKeys == Keys.Alt)
                {
                    if (Math.Abs(x1 - x2) > Math.Abs(y1 - y2))
                        y2 = y1;
                    else
                        x2 = x1;
                }    
                if (Control.ModifierKeys == Keys.Control)
                {
                    x2 = x2 / 10 * 10;
                    x1 = x1 / 10 * 10;
                }
            }
            graphics.DrawLine(pen, x1, y1, x2, y2);
        }
    }
}
