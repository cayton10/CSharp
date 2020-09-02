using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Assignment1
    {
        static void Main(string[] args)
        {
            //Declare variables
            double a;
            double b;
            double c;
            double y;
            double x;

            //Declare instance of Line object
            Line myLine;
            myLine = new Line();

            Console.WriteLine("If ax + by = c, enter a value for a:");
            
            a = double.Parse(Console.ReadLine());//Read user input into local variable: a      
            myLine.A = a;//Set value for a

            Console.WriteLine("Enter a value for b:");
            b = double.Parse(Console.ReadLine());
            myLine.B = b;

            Console.WriteLine("Enter a value for c:");
            c = double.Parse(Console.ReadLine());
            myLine.C = c;

            //Calculate value of x for given y
            Console.WriteLine("Enter a value for y to determine x:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine($"The value of x for the corresponding y of {y} is {myLine.ReturnX(y)}");

            //Calculate value of y for given x
            Console.WriteLine("Enter a value for x to determine y:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine($"The value of y for the corresponding x of {x} is {myLine.ReturnY(x)}");

            //Call function to determine slope of line
            Console.WriteLine($"The slope of the line is: {myLine.ReturnSlope()}");

        }
    }
}
