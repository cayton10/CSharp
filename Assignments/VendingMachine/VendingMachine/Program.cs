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
            //Create temp array to store vending items
            Item[] tempArray =
                {

                    new Item("Cheetoh's", 0.99, 10),
                    new Item("Slim Jim", 1.25, 15),
                    new Item("Popcorn", 0.99, 10),
                    new Item("Potato Skins", 1.25, 12),
                    new Item("Caviar", 500.00, 1)
                };
            //Instantiate the vendor class to accept items into array of Item type
            Vendor machine;
            machine = new Vendor(tempArray);

            machine.SelectItem();

        }
    }
}
