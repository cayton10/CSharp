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
<<<<<<< HEAD
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
=======
            //Instantiate ships
            Ship ship1 = new Ship(20, "Enterprise", 50, 50);
            Ship ship2 = new Ship(100, "Millenium Falcon", 50, 100);
            Ship ship3 = new Ship(25, "Santa Maria", 75, 80);

            //Instantiate Boats
            Boat boat1 = new Boat(1, "A Boat", 2);
            Boat boat2 = new Boat(2, "Seabass", 4);
            Boat boat3 = new Boat(3, "Marlin", 4);

            //Load all vessels into an array for processing
            Vessel[] vessels = { ship1, ship2, ship3, boat1, boat2, boat3 };

            //Set move speed for each vessel
            foreach(Vessel vessel in vessels)
            {
                //Output vessel attributes prior to calling Move() method
                Console.WriteLine(vessel.ToString());
                //Try the method
                try
                {
                    vessel.Move();
                }
                catch(NotImplementedException notImp)
                {
                    Console.WriteLine(notImp.Message);
                }

                //Output vessel attributes after calling Move() method
>>>>>>> inheritance
                Console.WriteLine(vessel.ToString());
            }


<<<<<<< HEAD
=======
            Cat cat1 = new Cat(17, 42);
            //Return formatted "hunger percentage output"
            Console.WriteLine($"Cat is {cat1.FuelPercentage.ToString("n2")}% full.");
            cat1.Refill(25);
            Console.WriteLine($"Cat is {cat1.FuelPercentage.ToString("n2")}% full.\n");
            cat1.Refill(30);

            Console.WriteLine($"{ship2.Name} has {ship2.FuelPercentage.ToString("n2")}% fuel remaining.");
            ship2.Refill(12);
            Console.WriteLine($"{ship2.Name} has {ship2.FuelPercentage.ToString("n2")}% fuel remaining after refueling.");

>>>>>>> inheritance
        }
    }
}
