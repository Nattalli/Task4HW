﻿namespace Task3
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
            this.label1 = new System.Windows.Forms.Label();
            this.FS = new System.Windows.Forms.TextBox();
            this.ss = new System.Windows.Forms.TextBox();
            this.ts = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the value of the triangle sides";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FS
            // 
            this.FS.Location = new System.Drawing.Point(62, 173);
            this.FS.Name = "FS";
            this.FS.Size = new System.Drawing.Size(180, 26);
            this.FS.TabIndex = 1;
            this.FS.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ss
            // 
            this.ss.Location = new System.Drawing.Point(304, 173);
            this.ss.Name = "ss";
            this.ss.Size = new System.Drawing.Size(180, 26);
            this.ss.TabIndex = 2;
            this.ss.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ts
            // 
            this.ts.Location = new System.Drawing.Point(551, 173);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(180, 26);
            this.ts.TabIndex = 3;
            this.ts.TextChanged += new System.EventHandler(this.ts_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Side 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Side 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(620, 209);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Side 3";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(275, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ts);
            this.Controls.Add(this.ss);
            this.Controls.Add(this.FS);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Enter the value of the parties";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FS;
        private System.Windows.Forms.TextBox ss;
        private System.Windows.Forms.TextBox ts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
    }
}

