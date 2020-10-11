namespace Task3
{
    partial class ChangeASide
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.side1 = new System.Windows.Forms.TextBox();
            this.side2 = new System.Windows.Forms.TextBox();
            this.side3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(317, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(271, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Which side would you like to change?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 210);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Side 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Side 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(63, 368);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Side 3";
            // 
            // side1
            // 
            this.side1.Location = new System.Drawing.Point(278, 204);
            this.side1.Name = "side1";
            this.side1.Size = new System.Drawing.Size(320, 26);
            this.side1.TabIndex = 6;
            // 
            // side2
            // 
            this.side2.Location = new System.Drawing.Point(278, 282);
            this.side2.Name = "side2";
            this.side2.Size = new System.Drawing.Size(320, 26);
            this.side2.TabIndex = 7;
            // 
            // side3
            // 
            this.side3.Location = new System.Drawing.Point(278, 362);
            this.side3.Name = "side3";
            this.side3.Size = new System.Drawing.Size(320, 26);
            this.side3.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(337, 441);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 43);
            this.button1.TabIndex = 9;
            this.button1.Text = "Change";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ChangeASide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 538);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.side3);
            this.Controls.Add(this.side2);
            this.Controls.Add(this.side1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ChangeASide";
            this.Text = "ChangeASide";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox side1;
        private System.Windows.Forms.TextBox side2;
        private System.Windows.Forms.TextBox side3;
        private System.Windows.Forms.Button button1;
    }
}