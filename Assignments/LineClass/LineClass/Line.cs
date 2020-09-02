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

            if (b != 0)
            {
                m = ((a * -1) / b);
            }
            else if (a == 0)
            {
                m = 0;//Value for horizontal slope
            }
            else
                //Else slope is undefined
                m = double.PositiveInfinity;

            return m;
        }

        //Determine whether two lines are parallel
        public bool Parallel(double val1, double val2)
        {
            bool parallel;//Declare variable to return

            if (val1 == val2)
                parallel = true;
            else
                parallel = false;

            return parallel;
        }
    }
}
