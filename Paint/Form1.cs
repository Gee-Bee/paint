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
using System.Globalization;
using System.Resources;
using System.Reflection;
using System.Threading;

namespace Paint
{
    public partial class Form1 : Form
    {
        private List<Shape> shapesAdded;
        private List<Shape> shapesRemoved;
        private Shape currentShape;
        private Drawer drawer;
        enum ShapeType { Line, Rect, Ellipse };
        ShapeType selectedShapeType = ShapeType.Line;
        Pen pen;

        CultureInfo ci;

        public Form1()
        {
            InitializeComponent();
            reset();
            ci = Thread.CurrentThread.CurrentUICulture;
            ChangeLanguage();
        }

        private void reset()
        {
            shapesAdded = new List<Shape>();
            shapesRemoved = new List<Shape>();
            drawer = new Drawer(shapesAdded);
            pen = new Pen(buttonColor.BackColor, (float)NumericUpDownPenSize.Value);
        }
        
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                switch (selectedShapeType)
                {
                    case ShapeType.Line:
                        currentShape = new Segment(e.X, e.Y, new Pen(buttonColor.BackColor, (float)NumericUpDownPenSize.Value));
                        break;
                    case ShapeType.Rect:
                        currentShape = new Rect(e.X, e.Y, new Pen(buttonColor.BackColor, (float)NumericUpDownPenSize.Value));
                        break;
                    case ShapeType.Ellipse:
                        currentShape = new Ellipse(e.X, e.Y, new Pen(buttonColor.BackColor, (float)NumericUpDownPenSize.Value));
                        break;
                }
                
        }

        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentShape.x2 = e.X;
                currentShape.y2 = e.Y;
                Canvas.Invalidate();
            }
        }

        private void Canvas_Paint(object sender, PaintEventArgs e)
        {
            drawer.Draw(e.Graphics, currentShape);
        }

        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                currentShape.stillDrawing = false;
                shapesAdded.Add(currentShape);
                currentShape = null;
                Canvas.Invalidate();
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

        private void englishToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("en-US");
            ChangeLanguage();
        }

        private void polskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ci = new CultureInfo("pl-PL");
            ChangeLanguage();
        }

        private void ChangeLanguage()
        {
            ResourceManager rm = new ResourceManager("Paint.i18n", Assembly.GetExecutingAssembly());

            languageToolStripMenuItem.Text = rm.GetString("language", ci);
            historyToolStripMenuItem.Text = rm.GetString("history", ci);
            undoToolStripMenuItem.Text = rm.GetString("undo", ci);
            redoToolStripMenuItem.Text = rm.GetString("redo", ci);
            fileToolStripMenuItem.Text = rm.GetString("file", ci);
            openToolStripMenuItem.Text = rm.GetString("open", ci);
            saveToolStripMenuItem.Text = rm.GetString("save", ci);

            groupBoxShapes.Text = rm.GetString("shapes", ci);
            buttonSegment.Text = rm.GetString("segment", ci);
            buttonRect.Text = rm.GetString("rect", ci);
            buttonEllipse.Text = rm.GetString("ellipse", ci);

            groupBoxPen.Text = rm.GetString("pen", ci);
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapesAdded.Count > 0)
            {
                Shape shape = shapesAdded[shapesAdded.Count - 1];
                shapesAdded.RemoveAt(shapesAdded.Count - 1);
                shapesRemoved.Add(shape);
                Canvas.Invalidate();
            }
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (shapesRemoved.Count > 0)
            {
                Shape shape = shapesRemoved[shapesRemoved.Count - 1];
                shapesRemoved.RemoveAt(shapesRemoved.Count - 1);
                shapesAdded.Add(shape);
                Canvas.Invalidate();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "bmp|*.bmp|jpg (*.jpg)|*.jpg";
            saveDialog.ShowDialog();
            if (saveDialog.FileName != "")
            {
                Bitmap bmp = new Bitmap(Canvas.Width, Canvas.Height);
                Canvas.DrawToBitmap(bmp, Canvas.Bounds);
                bmp.Save(saveDialog.FileName); 
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "bmp|*.bmp|jpg (*.jpg)|*.jpg";
            openDialog.ShowDialog();
            if (openDialog.FileName != "")
            {
                reset();
                Canvas.Image = Image.FromFile(openDialog.FileName);
            }
        }

        
    }

}
