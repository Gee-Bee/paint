using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Shapes
{
    class Rect : Shape
    {
        int width;
        int height;

        public Rect(int x, int y, Pen pen) : base(x, y, pen) { }

        public override void Draw(Graphics graphics)
        {
            if (stillDrawing)
            {
                width = Math.Abs(x2 - x1);
                height = Math.Abs(y2 - y1);
                if (Control.ModifierKeys == Keys.Alt)
                {
                    width = height = Math.Max(width, height);
                }                
                if (Control.ModifierKeys == Keys.Control)
                {
                    width = width / 10 * 10;
                    height = height / 10 * 10;
                }
            }
            graphics.DrawRectangle(pen, Math.Min(x1, x2), Math.Min(y1, y2), width, height);
        }
    }
}
