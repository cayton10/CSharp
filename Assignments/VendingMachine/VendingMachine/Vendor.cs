using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Vendor
    {
        //Declare private member of Item array type
        private Item[] ItemArray;


        //Vendor constructor
        public Vendor(Item[] array)
        {
            //Create array with project specified size
            ItemArray = new Item[5];
            //Load array passed from ctor to private Item array
            ItemArray = array;
        }


        //Print menu
        public void printMenu()
        {
            //Process array and print options to user until selection is
            //made
            String s = String.Format("{0, -17} {1, -7} {2, -4} \n\n", "Item:", "Price:", "Qty:");
            foreach(Item item in ItemArray)
            {
                s += String.Format("{0, -17} {1, 6} {2, 5}\n", item.Name, item.Price, item.Quantity);
            }
            Console.WriteLine($"Please select from the following options. \n\n{s}");
        }


    }
}
