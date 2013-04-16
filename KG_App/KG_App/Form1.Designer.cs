namespace KG_App
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsBrush = new System.Windows.Forms.ToolStripLabel();
            this.tsSize = new System.Windows.Forms.ToolStripTextBox();
            this.Canvas = new System.Windows.Forms.Panel();
            this.tsColorbtn = new System.Windows.Forms.ToolStripButton();
            this.tsClearbtn = new System.Windows.Forms.ToolStripButton();
            this.tsCanvasColorbtn = new System.Windows.Forms.ToolStripButton();
            this.tsShapeBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.squareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsShapeSize = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsBrush,
            this.tsSize,
            this.tsColorbtn,
            this.tsCanvasColorbtn,
            this.tsShapeBtn,
            this.tsShapeSize,
            this.tsClearbtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(835, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsBrush
            // 
            this.tsBrush.Name = "tsBrush";
            this.tsBrush.Size = new System.Drawing.Size(83, 22);
            this.tsBrush.Text = "Brush Size (px)";
            // 
            // tsSize
            // 
            this.tsSize.Name = "tsSize";
            this.tsSize.Size = new System.Drawing.Size(100, 25);
            this.tsSize.Text = "1";
            // 
            // Canvas
            // 
            this.Canvas.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Canvas.Cursor = System.Windows.Forms.Cursors.Cross;
            this.Canvas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Canvas.Location = new System.Drawing.Point(0, 25);
            this.Canvas.Name = "Canvas";
            this.Canvas.Size = new System.Drawing.Size(835, 426);
            this.Canvas.TabIndex = 1;
            this.Canvas.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseDown);
            this.Canvas.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseMove);
            this.Canvas.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Canvas_MouseUp);
            // 
            // tsColorbtn
            // 
            this.tsColorbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsColorbtn.Image = ((System.Drawing.Image)(resources.GetObject("tsColorbtn.Image")));
            this.tsColorbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsColorbtn.Name = "tsColorbtn";
            this.tsColorbtn.Size = new System.Drawing.Size(66, 22);
            this.tsColorbtn.Text = "Fore Color";
            this.tsColorbtn.Click += new System.EventHandler(this.tsColorbtn_Click);
            // 
            // tsClearbtn
            // 
            this.tsClearbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsClearbtn.Image = ((System.Drawing.Image)(resources.GetObject("tsClearbtn.Image")));
            this.tsClearbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsClearbtn.Name = "tsClearbtn";
            this.tsClearbtn.Size = new System.Drawing.Size(79, 22);
            this.tsClearbtn.Text = "Clear Canvas";
            this.tsClearbtn.Click += new System.EventHandler(this.tsClearbtn_Click);
            // 
            // tsCanvasColorbtn
            // 
            this.tsCanvasColorbtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsCanvasColorbtn.Image = ((System.Drawing.Image)(resources.GetObject("tsCanvasColorbtn.Image")));
            this.tsCanvasColorbtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsCanvasColorbtn.Name = "tsCanvasColorbtn";
            this.tsCanvasColorbtn.Size = new System.Drawing.Size(68, 22);
            this.tsCanvasColorbtn.Text = "Back Color";
            this.tsCanvasColorbtn.Click += new System.EventHandler(this.tsCanvasColorbtn_Click);
            // 
            // tsShapeBtn
            // 
            this.tsShapeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsShapeBtn.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.squareToolStripMenuItem,
            this.rectToolStripMenuItem,
            this.circleToolStripMenuItem});
            this.tsShapeBtn.Image = ((System.Drawing.Image)(resources.GetObject("tsShapeBtn.Image")));
            this.tsShapeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsShapeBtn.Name = "tsShapeBtn";
            this.tsShapeBtn.Size = new System.Drawing.Size(60, 22);
            this.tsShapeBtn.Text = "Shapes";
            // 
            // squareToolStripMenuItem
            // 
            this.squareToolStripMenuItem.Name = "squareToolStripMenuItem";
            this.squareToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.squareToolStripMenuItem.Text = "Square";
            this.squareToolStripMenuItem.Click += new System.EventHandler(this.squareToolStripMenuItem_Click);
            // 
            // rectToolStripMenuItem
            // 
            this.rectToolStripMenuItem.Name = "rectToolStripMenuItem";
            this.rectToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rectToolStripMenuItem.Text = "Rect";
            this.rectToolStripMenuItem.Click += new System.EventHandler(this.rectToolStripMenuItem_Click);
            // 
            // circleToolStripMenuItem
            // 
            this.circleToolStripMenuItem.Name = "circleToolStripMenuItem";
            this.circleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.circleToolStripMenuItem.Text = "Circle";
            this.circleToolStripMenuItem.Click += new System.EventHandler(this.circleToolStripMenuItem_Click);
            // 
            // tsShapeSize
            // 
            this.tsShapeSize.Name = "tsShapeSize";
            this.tsShapeSize.Size = new System.Drawing.Size(40, 25);
            this.tsShapeSize.Text = "50";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 451);
            this.Controls.Add(this.Canvas);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Paint V1";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel tsBrush;
        private System.Windows.Forms.ToolStripTextBox tsSize;
        private System.Windows.Forms.Panel Canvas;
        private System.Windows.Forms.ToolStripButton tsColorbtn;
        private System.Windows.Forms.ToolStripButton tsClearbtn;
        private System.Windows.Forms.ToolStripButton tsCanvasColorbtn;
        private System.Windows.Forms.ToolStripSplitButton tsShapeBtn;
        private System.Windows.Forms.ToolStripMenuItem squareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem circleToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox tsShapeSize;
    }
}

