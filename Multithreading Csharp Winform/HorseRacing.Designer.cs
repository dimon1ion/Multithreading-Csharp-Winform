namespace Multithreading_Csharp_Winform
{
    partial class HorseRacing
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Horse1 = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Horse2 = new System.Windows.Forms.ProgressBar();
            this.label3 = new System.Windows.Forms.Label();
            this.Horse3 = new System.Windows.Forms.ProgressBar();
            this.label4 = new System.Windows.Forms.Label();
            this.Horse4 = new System.Windows.Forms.ProgressBar();
            this.label5 = new System.Windows.Forms.Label();
            this.Horse5 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(93, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "start";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // progressBar1
            // 
            this.Horse1.Location = new System.Drawing.Point(12, 75);
            this.Horse1.Name = "progressBar1";
            this.Horse1.Size = new System.Drawing.Size(685, 23);
            this.Horse1.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 15);
            this.label1.TabIndex = 19;
            this.label1.Text = "Horse: #1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 21;
            this.label2.Text = "Horse: #2";
            // 
            // progressBar2
            // 
            this.Horse2.Location = new System.Drawing.Point(12, 137);
            this.Horse2.Name = "progressBar2";
            this.Horse2.Size = new System.Drawing.Size(685, 23);
            this.Horse2.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 23;
            this.label3.Text = "Horse: #3";
            // 
            // progressBar3
            // 
            this.Horse3.Location = new System.Drawing.Point(12, 206);
            this.Horse3.Name = "progressBar3";
            this.Horse3.Size = new System.Drawing.Size(685, 23);
            this.Horse3.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 15);
            this.label4.TabIndex = 25;
            this.label4.Text = "Horse: #4";
            // 
            // progressBar4
            // 
            this.Horse4.Location = new System.Drawing.Point(12, 278);
            this.Horse4.Name = "progressBar4";
            this.Horse4.Size = new System.Drawing.Size(685, 23);
            this.Horse4.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 15);
            this.label5.TabIndex = 27;
            this.label5.Text = "Horse: #5";
            // 
            // progressBar5
            // 
            this.Horse5.Location = new System.Drawing.Point(12, 349);
            this.Horse5.Name = "progressBar5";
            this.Horse5.Size = new System.Drawing.Size(685, 23);
            this.Horse5.TabIndex = 26;
            // 
            // HorseRacing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Horse5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Horse4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Horse3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Horse2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Horse1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HorseRacing";
            this.Text = "HorseRacing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ProgressBar Horse1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar Horse2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar Horse3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ProgressBar Horse4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ProgressBar Horse5;
    }
}