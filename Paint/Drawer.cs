using Paint.Shapes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Paint
{
    class Drawer
    {
        List<Shape> shapes;

        public Drawer(List<Shape> shapes)
        {
            this.shapes = shapes;
        }

        public void Draw(Graphics graphics)
        {
            foreach(var shape in shapes) shape.Draw(graphics);
        }

        public void Draw(Graphics graphics, Shape shape)
        {
            Draw(graphics);
            if (shape != null) shape.Draw(graphics);
        }
    }
}
