using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace KG_Threading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        Thread thread1, thread2;
        private void Form1_Load(object sender, EventArgs e)
        {
            ThreadStart threadstrt1 = new ThreadStart(drawCircle1);
            thread1 = new Thread(threadstrt1);

            ThreadStart threadstrt2 = new ThreadStart(drawCircle2);
            thread2 = new Thread(threadstrt2);

        }



        private void drawCircle1()
        {
            try
            {
                Random rand = new Random();
                Graphics g = Canvas1.CreateGraphics();
                for (int i = 0; i < 500000; i++)
                {
                    g.DrawEllipse(Pens.Purple, 0, 0, rand.Next(this.Width), rand.Next(this.Height));
                    Thread.Sleep(10);

                }
            }
            catch (Exception ex) { }
        }

        private void drawCircle2()
        {
            try
            {
                Random rand = new Random();
                Graphics g = Canvas2.CreateGraphics();
                for (int i = 0; i < 500000; i++)
                {
                    g.DrawEllipse(Pens.Gold, 0, 0, rand.Next(this.Width), rand.Next(this.Height));
                    Thread.Sleep(10);
                    
                }
            }
            catch (Exception ex) { }
        }

        private void btnStart1_Click(object sender, EventArgs e)
        {
            
            thread1.Resume();
            btnStart1.Enabled = false;
            btnPause1.Enabled = true;
        }

        private void btnPause1_Click(object sender, EventArgs e)
        {
            thread1.Suspend();
            btnPause1.Enabled = false;
            btnStart1.Enabled = true;
        }

        private void btnStartTHreads_Click(object sender, EventArgs e)
        {     
            thread1.Start();
            thread2.Start();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
        }

        private void btnStart2_Click(object sender, EventArgs e)
        {
            thread2.Resume();
            btnStart2.Enabled = false;
            btnPause2.Enabled = true;
        }

        private void btnPause2_Click(object sender, EventArgs e)
        {
            thread2.Suspend();
            btnPause2.Enabled = false;
            btnStart2.Enabled = true;
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            thread1.Abort();
            thread2.Abort();
        }
    }

}
