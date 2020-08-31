using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountTest
{
    //Public class Account available system wide
    public class Account
    {
        //Name of account holder
        //private string name;
        //Getter returns string
        //public string GetName()
        //{
        //    return name;
        //}
        //Setter void function
        //public void SetName(string accountName)
        //{
        //    name = accountName;
        //}

        //Name property
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Balance property
        private decimal balance;

        public decimal Balance
        {
            get { return balance; }
            set { //balance = value; 
                if (value >= 0)
                {
                    balance = value;
                }
            }
        }

        public void Deposit(decimal depositAmount)
        {
            if(depositAmount > 0)
                Balance = Balance + depositAmount;
        }

        //Default constructor
        public Account(string accountName) 
        {
            Name = accountName;
        }

    }
}
