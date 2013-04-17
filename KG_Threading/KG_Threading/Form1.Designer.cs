namespace KG_Threading
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
            this.Canvas1 = new System.Windows.Forms.Panel();
            this.Canvas2 = new System.Windows.Forms.Panel();
            this.btnStart1 = new System.Windows.Forms.Button();
            this.btnPause1 = new System.Windows.Forms.Button();
            this.btnStart2 = new System.Windows.Forms.Button();
            this.btnPause2 = new System.Windows.Forms.Button();
            this.btnStartTHreads = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Canvas1
            // 
            this.Canvas1.Location = new System.Drawing.Point(14, 80);
            this.Canvas1.Name = "Canvas1";
            this.Canvas1.Size = new System.Drawing.Size(375, 353);
            this.Canvas1.TabIndex = 0;
            // 
            // Canvas2
            // 
            this.Canvas2.Location = new System.Drawing.Point(418, 80);
            this.Canvas2.Name = "Canvas2";
            this.Canvas2.Size = new System.Drawing.Size(375, 353);
            this.Canvas2.TabIndex = 1;
            // 
            // btnStart1
            // 
            this.btnStart1.Enabled = false;
            this.btnStart1.Location = new System.Drawing.Point(14, 459);
            this.btnStart1.Name = "btnStart1";
            this.btnStart1.Size = new System.Drawing.Size(175, 52);
            this.btnStart1.TabIndex = 2;
            this.btnStart1.Text = "Resume Thread 1";
            this.btnStart1.UseVisualStyleBackColor = true;
            this.btnStart1.Click += new System.EventHandler(this.btnStart1_Click);
            // 
            // btnPause1
            // 
            this.btnPause1.Location = new System.Drawing.Point(214, 460);
            this.btnPause1.Name = "btnPause1";
            this.btnPause1.Size = new System.Drawing.Size(175, 51);
            this.btnPause1.TabIndex = 3;
            this.btnPause1.Text = "Pause Thread 1";
            this.btnPause1.UseVisualStyleBackColor = true;
            this.btnPause1.Click += new System.EventHandler(this.btnPause1_Click);
            // 
            // btnStart2
            // 
            this.btnStart2.Enabled = false;
            this.btnStart2.Location = new System.Drawing.Point(418, 460);
            this.btnStart2.Name = "btnStart2";
            this.btnStart2.Size = new System.Drawing.Size(175, 52);
            this.btnStart2.TabIndex = 4;
            this.btnStart2.Text = "Resume Thread 2";
            this.btnStart2.UseVisualStyleBackColor = true;
            this.btnStart2.Click += new System.EventHandler(this.btnStart2_Click);
            // 
            // btnPause2
            // 
            this.btnPause2.Location = new System.Drawing.Point(618, 461);
            this.btnPause2.Name = "btnPause2";
            this.btnPause2.Size = new System.Drawing.Size(175, 51);
            this.btnPause2.TabIndex = 5;
            this.btnPause2.Text = "Pause Thread  2";
            this.btnPause2.UseVisualStyleBackColor = true;
            this.btnPause2.Click += new System.EventHandler(this.btnPause2_Click);
            // 
            // btnStartTHreads
            // 
            this.btnStartTHreads.Location = new System.Drawing.Point(268, 12);
            this.btnStartTHreads.Name = "btnStartTHreads";
            this.btnStartTHreads.Size = new System.Drawing.Size(273, 50);
            this.btnStartTHreads.TabIndex = 6;
            this.btnStartTHreads.Text = "Start Threads";
            this.btnStartTHreads.UseVisualStyleBackColor = true;
            this.btnStartTHreads.Click += new System.EventHandler(this.btnStartTHreads_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 548);
            this.Controls.Add(this.btnStartTHreads);
            this.Controls.Add(this.btnPause2);
            this.Controls.Add(this.btnStart2);
            this.Controls.Add(this.btnPause1);
            this.Controls.Add(this.btnStart1);
            this.Controls.Add(this.Canvas2);
            this.Controls.Add(this.Canvas1);
            this.Name = "Form1";
            this.Text = "KG_MultiTHreads";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Canvas1;
        private System.Windows.Forms.Panel Canvas2;
        private System.Windows.Forms.Button btnStart1;
        private System.Windows.Forms.Button btnPause1;
        private System.Windows.Forms.Button btnStart2;
        private System.Windows.Forms.Button btnPause2;
        private System.Windows.Forms.Button btnStartTHreads;
    }
}

