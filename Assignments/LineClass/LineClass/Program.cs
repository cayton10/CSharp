//Name: Benjamin Cayton
//Course: CIT265 - C# Programming
//Date: 9.1.2020
/*******************************************************/
/*Program Description: This program acts as a linear algebra
 * calculator. The program itself relies on the implementation
 * of a 'Line' class to solve for variables, slope, and line
 * intersection for a line equation in standard format.*/


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
            double y;
            double x;
            string val;//This is our resuable variable for input validation function
            bool parallel;
            bool perpendicular;


            //Declare instance of Line object
            Line firstLine;
            firstLine = new Line();

            //Declare second instance of Line object
            Line secondLine;
            secondLine = new Line();

            Console.WriteLine("If ax + by = c, enter a value for a:");

            /***************************INPUTS FOR FIRST LINE****************************/
            
            val = Console.ReadLine();//Read user input into local variable: a
            //Set value of object (a) using ValidateNum function
            firstLine.A = firstLine.ValidateNum(val);

            Console.WriteLine("Enter a value for b:");
            val = Console.ReadLine();
            firstLine.B = firstLine.ValidateNum(val);

            Console.WriteLine("Enter a value for c:");
            val = Console.ReadLine();
            firstLine.C = firstLine.ValidateNum(val);

            //Calculate value of x for given y
            Console.WriteLine("Enter a value for y to determine x:");
            y = double.Parse(Console.ReadLine());
            Console.WriteLine($"The value of x for the corresponding y of {y} is {firstLine.ReturnX(y)}");

            //Calculate value of y for given x
            Console.WriteLine("Enter a value for x to determine y:");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine($"The value of y for the corresponding x of {x} is {firstLine.ReturnY(x)}");

            //Call function to determine slope of line
            Console.WriteLine($"The slope of the line is: {firstLine.ReturnSlope()}");


            /**********************INPUTS FOR SECOND LINE*******************************/

            Console.WriteLine("Enter a value for a of second line: ");

            val = Console.ReadLine();
            secondLine.A = secondLine.ValidateNum(val);

            Console.WriteLine("Enter a value for b of second line: ");

            val = Console.ReadLine();
            secondLine.B = secondLine.ValidateNum(val);

            Console.Write("Enter a value for c of second line: ");

            val = Console.ReadLine();
            secondLine.C = secondLine.ValidateNum(val);

            /**********************OUTPUT MULTI LINE RELATIONSHIPS**********************/

            //Set boolean value for parallel
            parallel = firstLine.Parallel(firstLine.ReturnSlope(), secondLine.ReturnSlope());
            //Set boolean value for perpendicular
            perpendicular = firstLine.Perpendicular(firstLine.ReturnSlope(), secondLine.ReturnSlope());

            //Control for output.
            if (parallel == true)
                Console.WriteLine("The two lines are parallel.");
            else if (perpendicular == true)
            {
                Console.WriteLine("The two lines are perpendicular.");
                //Call Intersection function
                firstLine.Intersect(
                    firstLine.A,   //Listed object parameters in cascading order because 
                    firstLine.B,   //It takes a lot of horizontal line space - readability
                    firstLine.C,
                    secondLine.A,
                    secondLine.B,
                    secondLine.C);
            }

            else
            {
                Console.WriteLine("The two lines are neither perpendicular nor parallel.");
                //Call Intersection function
                firstLine.Intersect(
                    firstLine.A,   //Listed object parameters in cascading order because 
                    firstLine.B,   //It takes a lot of horizontal line space - readability
                    firstLine.C,
                    secondLine.A,
                    secondLine.B,
                    secondLine.C);
            }

        }
    }
}
