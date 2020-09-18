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

        //Getters for all item properties
        public string Name
        {
            get { return name; }
        }

        public int Quantity
        {
            get { return quantity; }
        }

        public double Price
        {
            get { return price; }
        }


        

    }
}
