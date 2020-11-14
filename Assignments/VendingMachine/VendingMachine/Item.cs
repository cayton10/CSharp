using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Item
    {
        //Declare private member vars
        private double price;
        private int quantity;
        private string name;

        //Item constructor
        public Item(string name, double price, int quantity)
        {
            //Set instance object member variables with ctor passed params
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }

        //Property setter / getters
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Quantity
        {
            set { quantity = value; }
            get { return quantity; }
        }

        public double Price
        {
            set { price = value; }
            get { return price; }
        }


        

    }
}
