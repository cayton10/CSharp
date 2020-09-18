using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Item[] tempArray = new Item[5];
            //Instantiate vending machine items on program start
            tempArray[0] = new Item("Cheetoh's", 0.99, 10);
            tempArray[1] = new Item("Slim Jim", 1.25, 15);
            tempArray[2] = new Item("Popcorn", 0.99, 10);
            tempArray[3] = new Item("Potato Skins", 1.25, 12);
            tempArray[4] = new Item("Caviar", 500.00, 1);
            

            //Instantiate the vendor class to accept items into array of Item type
            Vendor machine;
            machine = new Vendor(tempArray);

            //Print menu to present user with options
            machine.printMenu();

        }
    }
}
