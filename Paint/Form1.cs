﻿using System;
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

        public Form1()
        {
            InitializeComponent();
            shapes = new List<Shape>();
            drawer = new Drawer(shapes);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentShape = new Line(e.X, e.Y);

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
            //e.Graphics.DrawEllipse(Pens.Black, Math.Min(x_start, x_end), Math.Min(y_start, y_end), Math.Abs(x_end - x_start), Math.Abs(y_start - y_end));

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                shapes.Add(currentShape);
                Invalidate();
            }
        }
    }

}
