using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Task3
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
             
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string f = FS.Text;
                string n = ss.Text;
                string d = ts.Text;
                double q = double.Parse(f);
                double w = double.Parse(n);
                double v = double.Parse(d);
                Triangle A = new Triangle(q, w, v);
                if ((q > w + v) || (w > q + v) || (v > q + w) || v <= 0 || w <= 0 || q <= 0)
                {
                    MessageBox.Show("Sides are incorrect");
                }
                else
                {
                    this.Hide();
                        Changes change = new Changes(A);
                        change.Show();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ts_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
