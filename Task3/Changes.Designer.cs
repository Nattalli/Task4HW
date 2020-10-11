namespace Task3
{
    partial class Changes
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
            this.firstbutton = new System.Windows.Forms.RadioButton();
            this.secondbutton = new System.Windows.Forms.RadioButton();
            this.thirdbutton = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.fourthbutton = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose the option:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // firstbutton
            // 
            this.firstbutton.AutoSize = true;
            this.firstbutton.Location = new System.Drawing.Point(201, 85);
            this.firstbutton.Name = "firstbutton";
            this.firstbutton.Size = new System.Drawing.Size(177, 24);
            this.firstbutton.TabIndex = 3;
            this.firstbutton.TabStop = true;
            this.firstbutton.Text = "Change a side/sides";
            this.firstbutton.UseVisualStyleBackColor = true;
            this.firstbutton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // secondbutton
            // 
            this.secondbutton.AutoSize = true;
            this.secondbutton.Location = new System.Drawing.Point(201, 128);
            this.secondbutton.Name = "secondbutton";
            this.secondbutton.Size = new System.Drawing.Size(198, 24);
            this.secondbutton.TabIndex = 4;
            this.secondbutton.TabStop = true;
            this.secondbutton.Text = "Сalculate the perimeter";
            this.secondbutton.UseVisualStyleBackColor = true;
            // 
            // thirdbutton
            // 
            this.thirdbutton.AutoSize = true;
            this.thirdbutton.Location = new System.Drawing.Point(201, 168);
            this.thirdbutton.Name = "thirdbutton";
            this.thirdbutton.Size = new System.Drawing.Size(170, 24);
            this.thirdbutton.TabIndex = 5;
            this.thirdbutton.TabStop = true;
            this.thirdbutton.Text = "Сalculate the angle";
            this.thirdbutton.UseVisualStyleBackColor = true;
            this.thirdbutton.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(285, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(232, 54);
            this.button1.TabIndex = 6;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fourthbutton
            // 
            this.fourthbutton.AutoSize = true;
            this.fourthbutton.Location = new System.Drawing.Point(201, 208);
            this.fourthbutton.Name = "fourthbutton";
            this.fourthbutton.Size = new System.Drawing.Size(445, 24);
            this.fourthbutton.TabIndex = 7;
            this.fourthbutton.TabStop = true;
            this.fourthbutton.Text = "Calculate an area(ONLY FOR EQUILIBRIUM TRIANGLE)";
            this.fourthbutton.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(201, 247);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(113, 24);
            this.radioButton1.TabIndex = 8;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Finish work";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged_1);
            // 
            // Changes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 420);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.fourthbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.thirdbutton);
            this.Controls.Add(this.secondbutton);
            this.Controls.Add(this.firstbutton);
            this.Controls.Add(this.label1);
            this.Name = "Changes";
            this.Text = "Changes";
            this.Load += new System.EventHandler(this.Changes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton firstbutton;
        private System.Windows.Forms.RadioButton secondbutton;
        private System.Windows.Forms.RadioButton thirdbutton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton fourthbutton;
        private System.Windows.Forms.RadioButton radioButton1;
    }
}