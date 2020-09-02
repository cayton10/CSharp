using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    class AccountTest
    {
        //Similar to C++ entry point
        static void Main(string[] args)
        {
            Account myAccount;//Declare myAccount variable of Account type
            //myAccount = new Account();//Create instance of class in memory

            myAccount = new Account("Jimmy Smith");
            Console.WriteLine($"Initial value of account name is: {myAccount.Name}");
            Console.WriteLine($"Initial balance is: {myAccount.Balance}");

            Console.WriteLine("Enter the account name:");//Prompt user
            string theName = Console.ReadLine();//Read user input
            //myAccount.SetName(theName);//Call setter method
            myAccount.Name = theName;

            //Console.WriteLine($"Initial value of name is: {myAccount.GetName()}");
            Console.WriteLine($"Value of account name is: {myAccount.Name}");

            Console.WriteLine("Enter the deposit amount:");//Prompt user
            decimal depositAmount = decimal.Parse(Console.ReadLine());
            myAccount.Deposit(depositAmount);
            Console.WriteLine($"New balance is: {myAccount.Balance}");
        }
    }
}
