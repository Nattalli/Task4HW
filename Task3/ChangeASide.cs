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
    public partial class ChangeASide : Form
    {
        public Triangle A;
        public ChangeASide()
        {
            InitializeComponent();
        }
        public ChangeASide(Triangle A)
        {
            InitializeComponent();
            this.A = A;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string f = side1.Text;
            string n = side2.Text;
            string d = side3.Text;
            try
            {
                if (f.Length != 0)
                {
                    double q = double.Parse(f);
                    A.SetFirstSide(q);
                }
                if (n.Length != 0)
                {
                    double w = double.Parse(n);
                    A.SetFirstSide(w);
                }
                if (d.Length != 0)
                {
                    double v = double.Parse(d);
                    A.SetFirstSide(v);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.Hide();

            Changes form = new Changes(A);
            form.Show();
        }
    }
}
