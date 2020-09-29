using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Ship ship1 = new Ship(20, "Enterprise", 50, 50);
            string v = ship1.ToString();
            Console.WriteLine(v);
            try
            {
                ship1.Move();
            }
            catch(NotImplementedException notImp)
            {
                Console.WriteLine(notImp.Message);
            }
            v = ship1.ToString();
            Console.WriteLine(v);
        }
    }
}
