using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public partial class Changes : Form
    {
        public Triangle A;
        
        public Changes()
        {
            InitializeComponent();
        }
       
        public Changes(Triangle A)
        {
            InitializeComponent();
            this.A = A;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( firstbutton.Checked == true)
            {
                this.Hide();

                ChangeASide form = new ChangeASide(A);
                form.Show();
            }
            if ( secondbutton.Checked == true)
            {
            MessageBox.Show("Perimeter = " + A.Perimeter() );
            }
            else if ( thirdbutton.Checked == true)
            {
                string ab = A.AngleAB().ToString();
                string bc = A.AngleBC().ToString();
                string ac = A.AngleAC().ToString();
                MessageBox.Show(" 1 - " + ab + "\n" + " 2 - " + bc + "\n" + " 3 - " + ac);
            }
            else if (fourthbutton.Checked == true)
            {
                  if (A.IsEquality())
                {
                   double Side = A.GetFirstSide();
                   MessageBox.Show("Area = " + (Side * Side * Math.Sqrt(3)) / 4);
                }
                else
                {
                  MessageBox.Show("ERROR! The triangle is not equlibrium! Try again.");
                }
                  
            }
            else if (fourthbutton.Checked == false && secondbutton.Checked == false && thirdbutton.Checked == false && firstbutton.Checked == false)
            {
                MessageBox.Show("Choose the option PLEASE");
            }
        }

        private void Changes_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
