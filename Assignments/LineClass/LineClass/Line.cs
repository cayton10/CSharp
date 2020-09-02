using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class Line
    {
        //Member variables for standard line equation ax + by = c
        private double a, b, c;

        //Line property A - Setter / Getter
        public double A
        {
            get { return a; }
            set { a = value; }
        }
        //Line property B - Setter / Getter
        public double B
        {
            get { return b; }
            set { b = value; }
        }
        //Line property C - Setter / Getter
        public double C
        {
            get { return c; }
            set { c = value; }
        }

        /************CLASS METHODS*******************/
        /********************************************/

        //Number input validation method
        public double ValidateNum(string input)
        {
            double value;//Value to return
            while (!double.TryParse(input, out value))
            {
                Console.WriteLine("Not a number, try again.");
                input = Console.ReadLine();
            }

            return value;
        }

        //Returns value of X for given Y value
        public double ReturnX(double value)
        {
            //ax + by = c

            double x;//Declare variable to return

            x = (c / a) - ((b * value) / a);
            return x;
        }

        //Returns value of Y for given X value
        public double ReturnY(double value)
        {
            double y;//Declare variable to return

            y = (c / b) - ((a * value) / b);
            return y;
        }

        //Returns slope of line
        public double ReturnSlope()
        {
            //Declare slope variable
            double m = 0;//Must be initialized, or won't compile

            if (a == 0)
            {
                m = 0;//Value for horizontal slope
            }
            else if (b != 0)
            {
                m = ((a * -1) / b);
            }
            else
                //Else slope is undefined
                m = double.PositiveInfinity;

            //Format number
            m = Math.Round(m, 2);
            return m;
        }

        //Determine whether two lines are parallel
        public bool Parallel(double val1, double val2)
        {
            bool parallel;//Declare variable to return

            //Ternary control for parallel lines
            parallel = val1 == val2 ? true : false;  

            return parallel;
        }

        //Determine whether two lines are perpendicular
        public bool Perpendicular(double val1, double val2)
        {
            bool perpendicular;//Declare variable to return

            if (val1 * val2 == -1)
                perpendicular = true;
            else if (val1 == 0 && val2 == double.PositiveInfinity)
                perpendicular = true;
            else if (val1 == double.PositiveInfinity && val2 == 0)
                perpendicular = true;
            else
                perpendicular = false;

            return perpendicular;
        }

        //Determine the point of intersection if lines are note parallel
        public void Intersect(double a1, double b1, double c1, double a2, double b2, double c2)
        {
            double pointX;//Declare point in 2D space to return
            //Find x intersection point formula
            pointX = Math.Round((((b1 * c2) - (b2 * c1)) / ((a1 * b2) - (a2 * b1))), 2);

            double pointY;
            //Find y intersection point formula
            pointY = Math.Round((((a2 * c1) - (a1 * c2)) / ((a1 * b2) - (a2 * b1))), 2);

            Console.WriteLine($"The intersection point of the two lines is: (x,y) = ({pointX}, {pointY}).");
        }
    }
}
