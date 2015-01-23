using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Paint.Shapes;

namespace Paint
{
    public partial class Form1 : Form
    {
        private int x_start;
        private int y_start;
        private int x_end;
        private int y_end;
        private List<Line> lines = new List<Line>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x_start = x_end = e.X;
                y_start = y_end = e.Y;

            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                x_end = e.X;
                y_end = e.Y;
                Invalidate();
            }
            //Graphics graphics = this.CreateGraphics();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // to co wymaga odświeżenia
            foreach (var line in lines)
            {
                e.Graphics.DrawLine(Pens.Black, line.x1, line.y1, line.x2, line.y2);
            }
            e.Graphics.DrawLine(Pens.Chocolate, x_start, y_start, x_end, y_end);
            //e.Graphics.DrawEllipse(Pens.Black, Math.Min(x_start, x_end), Math.Min(y_start, y_end), Math.Abs(x_end - x_start), Math.Abs(y_start - y_end));

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                lines.Add(new Line(x_start, y_start, x_end, y_end));
                Invalidate();
            }
        }
    }

}
