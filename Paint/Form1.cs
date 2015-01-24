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
        private List<Shape> shapes;
        private Shape currentShape;
        private Drawer drawer;
        enum ShapeType { Line, Rect, Ellipse };
        ShapeType selectedShapeType = ShapeType.Line;
        Pen pen;

        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            drawer = new Drawer(shapes);
            pen = new Pen(buttonColor.BackColor, (float)NumericUpDownPenSize.Value);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                switch (selectedShapeType)
                {
                    case ShapeType.Line:
                        currentShape = new Line(e.X, e.Y, new Pen(buttonColor.BackColor, (float)NumericUpDownPenSize.Value));
                        break;
                    case ShapeType.Rect:
                        currentShape = new Rect(e.X, e.Y, new Pen(buttonColor.BackColor, (float)NumericUpDownPenSize.Value));
                        break;
                    case ShapeType.Ellipse:
                        currentShape = new Ellipse(e.X, e.Y, new Pen(buttonColor.BackColor, (float)NumericUpDownPenSize.Value));
                        break;
                }
                
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentShape.x2 = e.X;
                currentShape.y2 = e.Y;
                Invalidate();
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            drawer.Draw(e.Graphics, currentShape);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentShape.stillDrawing = false;
                shapes.Add(currentShape);
                currentShape = null;
                Invalidate();
            }
        }

        private void buttonLine_Click(object sender, EventArgs e)
        {
            selectedShapeType = ShapeType.Line;
        }

        private void buttonRect_Click(object sender, EventArgs e)
        {
            selectedShapeType = ShapeType.Rect;
        }

        private void buttonEllipse_Click(object sender, EventArgs e)
        {
            selectedShapeType = ShapeType.Ellipse;
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            colorDialog1.Color = buttonColor.BackColor;
            colorDialog1.ShowDialog();
            pen.Color = buttonColor.BackColor = colorDialog1.Color;
        }

        private void NumericUpDownPenSize_ValueChanged(object sender, EventArgs e)
        {
            pen.Width = (float)((NumericUpDown)sender).Value;
        }
    }

}
