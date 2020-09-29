using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Why am I here? Lol
    public class Cat
    {
        private int hunger;
        private int maxHunger;

        //Property setter/getter
        public int Hunger
        {
            get { return hunger; }
            set { hunger = value; }
        }

        public int MaxHunger
        {
            get { return maxHunger; }
            set { maxHunger = value; }
        }

        //Cat ctor
        public Cat(int hunger, int maxHunger)
        {
            this.hunger = hunger;
            this.maxHunger = maxHunger;
        }
    }
}
