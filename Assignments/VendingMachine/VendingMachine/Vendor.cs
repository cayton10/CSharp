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
        private Item[] itemArray;
        private int selection;
        private int quantity;


        //Vendor constructor
        public Vendor(Item[] array)
        {
            //Load array passed from ctor to private Item array
            itemArray = new Item[5];
            //Load array passed from ctor to private Item array
            itemArray = array;

        }

        //Public member function for user selection
        public void SelectItem()
        {
            do
            {
                string userChoice;
                //Define user choice variable
                PrintMenu();
                userChoice = Console.ReadLine();
                //Validate user input
                selection = ValidateNum(userChoice);

                //If user selection value out of range
                if ((selection < 1 || selection > 5) && selection != 0)
                {
                    Console.WriteLine("Please select from the options available (1-5).");
                }
            }
            while ((selection < 1 || selection > 5) && selection != 0);
            //If user selects exit key,
            if (selection == 0)
            {
                Environment.Exit(0);//Exit gracefully.
            }
            else
                SelectItem();
        }


        //Print menu
        public void PrintMenu()
        {
            //Process array and print options to user until selection is
            //made
            String s = String.Format("{0, -2} {1, -16} {2, -4} {3, 6} \n\n","#", "Item:", "Price:", "Qty:");
            int i = 1;
            foreach (Item item in itemArray)
            {
                s += String.Format("{0, -2} {1, -16} {2, 6} {3, 6}\n", $"{i}.", item.Name, item.Price, item.Quantity);
                ++i;
            }
            Console.WriteLine($"Please select from the following options. Press '0' to exit. \n\n{s}");
        }

        //Number input validation method
        public int ValidateNum(string input)
        {
            int value;//Value to return
            while (!int.TryParse(input, out value))
            {
                Console.WriteLine("Not a number, try again.");
                SelectItem();
                input = Console.ReadLine();
            }

            return value;
        }


    }
}
