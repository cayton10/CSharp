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
            //Create ships
            Ship ship1 = new Ship(10, "Enterprise", 15, 50);
            Ship ship2 = new Ship(100, "Millenium Falcon", 50, 100);
            Ship ship3 = new Ship(10, "Santa Maria", 25, 25);
            //Create boats
            Boat boat1 = new Boat(1, "A Boat", 2);
            Boat boat2 = new Boat(3, "Seabass", 4);
            Boat boat3 = new Boat(4, "Marlin", 6);

            //Load all vessels into vessels array for processing
            Vessel[] vessels = { ship1, ship2, ship3, boat1, boat2, boat3 };

            //Using single foreach, make vessels use appropriate Move() method
            foreach(Vessel vessel in vessels)
            {
                Console.WriteLine(vessel.ToString());
                vessel.Move();
                Console.WriteLine(vessel.ToString());
            }


        }
    }
}
