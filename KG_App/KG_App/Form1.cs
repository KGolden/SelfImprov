using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace KG_App
{
    public partial class Form1 : Form
    {

        //define necessary vars
        bool canDraw = false;
        Graphics g;
        int? prevX, prevY  = null;
        bool drawSquare,drawRect,drawCirc = false;

        //init form
        public Form1()
        {
            InitializeComponent();
            //for graphics
            g = Canvas.CreateGraphics();

        }

        //MouseDown Even Handler
        private void Canvas_MouseDown(object sender, MouseEventArgs e)
        {
            canDraw = true;

            //if user picked a square
            if (drawSquare)
            {
                SolidBrush s = new SolidBrush(tsColorbtn.ForeColor);
                g.FillRectangle(s, e.X, e.Y, Convert.ToInt32(tsShapeSize.Text), Convert.ToInt32(tsShapeSize.Text));
                canDraw = false;
                drawSquare = false;
            }

            //if UserControl picked rect
            else if(drawRect)
            {
                SolidBrush s = new SolidBrush(tsColorbtn.ForeColor);
                g.FillRectangle(s, e.X, e.Y, Convert.ToInt32(tsShapeSize.Text)*2, Convert.ToInt32(tsShapeSize.Text));
                canDraw = false;
                drawRect = false;
            }
            //if user picked circ
            else if (drawCirc)
            {
                SolidBrush s = new SolidBrush(tsColorbtn.ForeColor);
                g.FillEllipse(s, e.X, e.Y, Convert.ToInt32(tsShapeSize.Text), Convert.ToInt32(tsShapeSize.Text));
                canDraw = false;
                drawCirc = false;
            }
      
        }

        //Mouse Up Event Handler
        private void Canvas_MouseUp(object sender, MouseEventArgs e)
        {

            canDraw = false;

            //set points back to null
            prevX = null;
            prevY = null;
        }


        //Mouse Movement event handler
        private void Canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (canDraw)
            {
                //do this
                try
                {
                    //new pen obj
                    Pen p = new Pen(tsColorbtn.ForeColor, float.Parse(tsSize.Text));
                    g.DrawLine(p, new Point(prevX ?? e.X, prevY ?? e.Y), new Point(e.X, e.Y));
                    prevX = e.X;
                    prevY = e.Y;
                }
                //catch exception if no brush size
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        //Button changes color we draw in
        private void tsColorbtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                tsColorbtn.ForeColor = cd.Color;
            }
        }


        //button clears canvas
        private void tsClearbtn_Click(object sender, EventArgs e)
        {
            g.Clear(Canvas.BackColor);
        }

        //button changes canvas (background) color
        private void tsCanvasColorbtn_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                tsCanvasColorbtn.ForeColor = cd.Color;
                Canvas.BackColor = cd.Color;
            }
        }

        //Square select
        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawSquare = true;
        }

        //Rectangle Select
        private void rectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawRect = true;
        }

        //Circle Select
        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawCirc = true;
        }
    }
}
