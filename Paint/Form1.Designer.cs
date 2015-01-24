namespace Paint
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBoxLeft = new System.Windows.Forms.GroupBox();
            this.groupBoxPen = new System.Windows.Forms.GroupBox();
            this.NumericUpDownPenSize = new System.Windows.Forms.NumericUpDown();
            this.buttonColor = new System.Windows.Forms.Button();
            this.groupBoxShapes = new System.Windows.Forms.GroupBox();
            this.buttonEllipse = new System.Windows.Forms.Button();
            this.buttonRect = new System.Windows.Forms.Button();
            this.buttonSegment = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.polskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxLeft.SuspendLayout();
            this.groupBoxPen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPenSize)).BeginInit();
            this.groupBoxShapes.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxLeft
            // 
            this.groupBoxLeft.Controls.Add(this.groupBoxPen);
            this.groupBoxLeft.Controls.Add(this.groupBoxShapes);
            this.groupBoxLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxLeft.Location = new System.Drawing.Point(0, 24);
            this.groupBoxLeft.Name = "groupBoxLeft";
            this.groupBoxLeft.Size = new System.Drawing.Size(120, 436);
            this.groupBoxLeft.TabIndex = 0;
            this.groupBoxLeft.TabStop = false;
            // 
            // groupBoxPen
            // 
            this.groupBoxPen.Controls.Add(this.NumericUpDownPenSize);
            this.groupBoxPen.Controls.Add(this.buttonColor);
            this.groupBoxPen.Location = new System.Drawing.Point(7, 137);
            this.groupBoxPen.Name = "groupBoxPen";
            this.groupBoxPen.Size = new System.Drawing.Size(107, 51);
            this.groupBoxPen.TabIndex = 2;
            this.groupBoxPen.TabStop = false;
            this.groupBoxPen.Text = "Pen";
            // 
            // NumericUpDownPenSize
            // 
            this.NumericUpDownPenSize.Location = new System.Drawing.Point(62, 20);
            this.NumericUpDownPenSize.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumericUpDownPenSize.Name = "NumericUpDownPenSize";
            this.NumericUpDownPenSize.Size = new System.Drawing.Size(39, 20);
            this.NumericUpDownPenSize.TabIndex = 1;
            this.NumericUpDownPenSize.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.NumericUpDownPenSize.ValueChanged += new System.EventHandler(this.NumericUpDownPenSize_ValueChanged);
            // 
            // buttonColor
            // 
            this.buttonColor.BackColor = System.Drawing.Color.Black;
            this.buttonColor.Location = new System.Drawing.Point(7, 20);
            this.buttonColor.Name = "buttonColor";
            this.buttonColor.Size = new System.Drawing.Size(48, 20);
            this.buttonColor.TabIndex = 0;
            this.buttonColor.UseVisualStyleBackColor = false;
            this.buttonColor.Click += new System.EventHandler(this.buttonColor_Click);
            // 
            // groupBoxShapes
            // 
            this.groupBoxShapes.Controls.Add(this.buttonEllipse);
            this.groupBoxShapes.Controls.Add(this.buttonRect);
            this.groupBoxShapes.Controls.Add(this.buttonSegment);
            this.groupBoxShapes.Location = new System.Drawing.Point(6, 12);
            this.groupBoxShapes.Name = "groupBoxShapes";
            this.groupBoxShapes.Size = new System.Drawing.Size(108, 118);
            this.groupBoxShapes.TabIndex = 1;
            this.groupBoxShapes.TabStop = false;
            this.groupBoxShapes.Text = "Shapes";
            // 
            // buttonEllipse
            // 
            this.buttonEllipse.Location = new System.Drawing.Point(7, 79);
            this.buttonEllipse.Name = "buttonEllipse";
            this.buttonEllipse.Size = new System.Drawing.Size(95, 23);
            this.buttonEllipse.TabIndex = 2;
            this.buttonEllipse.Text = "button2";
            this.buttonEllipse.UseVisualStyleBackColor = true;
            this.buttonEllipse.Click += new System.EventHandler(this.buttonEllipse_Click);
            // 
            // buttonRect
            // 
            this.buttonRect.Location = new System.Drawing.Point(7, 50);
            this.buttonRect.Name = "buttonRect";
            this.buttonRect.Size = new System.Drawing.Size(95, 23);
            this.buttonRect.TabIndex = 1;
            this.buttonRect.Text = "button1";
            this.buttonRect.UseVisualStyleBackColor = true;
            this.buttonRect.Click += new System.EventHandler(this.buttonRect_Click);
            // 
            // buttonSegment
            // 
            this.buttonSegment.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSegment.Location = new System.Drawing.Point(7, 21);
            this.buttonSegment.Name = "buttonSegment";
            this.buttonSegment.Size = new System.Drawing.Size(95, 23);
            this.buttonSegment.TabIndex = 0;
            this.buttonSegment.Text = "button1";
            this.buttonSegment.UseVisualStyleBackColor = true;
            this.buttonSegment.Click += new System.EventHandler(this.buttonLine_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.languageToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1011, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.polskiToolStripMenuItem});
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.languageToolStripMenuItem.Text = "Language";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.englishToolStripMenuItem_Click);
            // 
            // polskiToolStripMenuItem
            // 
            this.polskiToolStripMenuItem.Name = "polskiToolStripMenuItem";
            this.polskiToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.polskiToolStripMenuItem.Text = "Polski";
            this.polskiToolStripMenuItem.Click += new System.EventHandler(this.polskiToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 460);
            this.Controls.Add(this.groupBoxLeft);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.groupBoxLeft.ResumeLayout(false);
            this.groupBoxPen.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumericUpDownPenSize)).EndInit();
            this.groupBoxShapes.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxLeft;
        private System.Windows.Forms.GroupBox groupBoxShapes;
        private System.Windows.Forms.Button buttonSegment;
        private System.Windows.Forms.Button buttonEllipse;
        private System.Windows.Forms.Button buttonRect;
        private System.Windows.Forms.GroupBox groupBoxPen;
        private System.Windows.Forms.NumericUpDown NumericUpDownPenSize;
        private System.Windows.Forms.Button buttonColor;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem polskiToolStripMenuItem;
    }
}

