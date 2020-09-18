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
                
                else if (selection == 0)//If user selects exit key, 
                {
                    Console.WriteLine("Thanks for shopping.");
                    Environment.Exit(0);//Exit gracefully.
                }
                else //User has valid selection
                {
                    //Prompt user to enter quantity desired
                    Console.WriteLine($"How many {itemArray[selection - 1].Name}" +
                        $" would you like to purchase?");
                    userChoice = Console.ReadLine();
                    //Validate user input
                    quantity = ValidateNum(userChoice);

                    //Call DispenseItem member function
                    DispenseItem(selection, quantity);
                }
                
            }
            while ((selection < 1 || selection > 5) && selection != 0);
            
        }


        //Print menu
        public void PrintMenu()
        {
            //Process array and print options to user until selection is
            //made
            String s = String.Format("{0, -2} {1, -16} {2, -4} {3, 6} \n\n","#", "Item:", "Price:", "Qty:");
            int i = 1;
            foreach (Item item in itemArray)//Lots of string formatting here to make pretty
            {
                //Format string for price printing
                string formattedString = String.Format("{0:0.00}", item.Price);
                s += String.Format("{0, -2} {1, -16} {2, 7} {3, 6}\n", $"{i}.", item.Name, $"${formattedString}", item.Quantity);
                ++i;
            }
            Console.WriteLine($"Please select from the following options. Press '0' to exit. \n\n{s}");
        }



        /*DispenseItem(int, int) VOID FUNCTION DISPENSES ITEM AND CALCULATES
         * USER TOTAL IF CONDITIONS OF APPROPRIATE VENDING STOCK ARE MET **/
        public void DispenseItem(int choice, int number)
        {
            //Reduce stocked item by quantity specified by user
            int newStock;
            newStock = (itemArray[choice - 1].Quantity - number);
            //Check for valid stock count
            if (newStock < 0)
            {
                Console.WriteLine($"Not enough {itemArray[choice - 1].Name}" +      //Message to user
                    $" in stock to complete this transaction.\nLower selection" +   //if conditions
                    $" quantity or select an in stock item.");                      //are not met
                SelectItem(); //Return to select item function
            } else
            {
                double totalCost;//Declare total cost variable
                totalCost = (itemArray[choice - 1].Price * number);//Calculate total
                string formatCost = String.Format("{0:0.00}", totalCost);                                                   //Report total to user
                Console.WriteLine($"Your total is: ${formatCost}.");
                //Reduce stock quantity upon successful transaction
                itemArray[choice - 1].Quantity = newStock;

                //Return user to menu for item selection
                SelectItem();
            }
        }

        //Number input validation method
        public int ValidateNum(string input)
        {
            int value;//Value to return
            while (!int.TryParse(input, out value))
            {
                Console.WriteLine("Not a valid selection, try again.");
                SelectItem();
                input = Console.ReadLine();
            }

            return value;
        }

    }
}
