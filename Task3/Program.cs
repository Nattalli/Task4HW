using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task3
{
    public class Triangle
    {
        public double FirstSide, SecondSide, ThirdSide;

        public Triangle()
        {

        }
        public Triangle(double a, double b, double c)
        {
            FirstSide = a;
            SecondSide = b;
            ThirdSide = c;
        }
        public bool IsEquality()
        {
            return FirstSide == SecondSide && FirstSide == ThirdSide && SecondSide == ThirdSide;
        }
        public void SetFirstSide(double a)
        {
            FirstSide = a;
        }

        public void SetSecondSide(double a)
        {
            SecondSide = a;
        }

        public void SetThirdSide(double a)
        {
            ThirdSide = a;
        }
        public double GetFirstSide()
        {
            return FirstSide;
        }

        public double GetSecondSide()
        {
            return SecondSide;
        }

        public double GetThirdSide()
        {
            return ThirdSide;
        }
        public double Perimeter()
        {
            return FirstSide + SecondSide + ThirdSide;
        }
        public double AngleAB()
        {
            double ab = Math.Acos((Math.Pow(FirstSide, 2) + Math.Pow(SecondSide, 2) - Math.Pow(ThirdSide, 2)) / (2 * FirstSide * SecondSide));
            return ab;
        }
        public double AngleBC()
        {
            double bc = Math.Acos((Math.Pow(SecondSide, 2) + Math.Pow(ThirdSide, 2) - Math.Pow(FirstSide, 2)) / (2 * ThirdSide * SecondSide));
            return bc;
        }
        public double AngleAC()
        {
            double ac = Math.Acos((Math.Pow(FirstSide, 2)  - Math.Pow(SecondSide, 2)+ Math.Pow(ThirdSide, 2)) / (2 * FirstSide * ThirdSide));
            return ac;
        }
    }

    public class EqulibriumTriangle : Triangle
    {
        public double Area()
        {
            return (FirstSide * FirstSide * Math.Sqrt(3)) / 4;
        }
    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
