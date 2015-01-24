using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.Shapes
{
    abstract class Shape
    {
        protected int x1;
        protected int y1;
        public int x2;
        public int y2;
        public Boolean stillDrawing;
        protected Pen pen;

        public Shape(int x, int y, Pen pen)
        {
            this.x1 = this.x2 = x;
            this.y1 = this.y2 = y;
            this.stillDrawing = true;
            this.pen = pen;
        }

        public abstract void Draw(Graphics graphics);
    }
}
