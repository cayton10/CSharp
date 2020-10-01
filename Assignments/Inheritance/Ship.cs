using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Public class, Ship inherits Vessel
    public class Ship : Vessel, IRefillable
    {
        //Private Ship member variables
        private int fuel;
        private int maxFuel;


        //Propfull setters/getters for Ship private members
        public int Fuel
        {
            get { return fuel; }
            set { fuel = value; }
        }

        public int MaxFuel
        {
            get { return maxFuel; }
            set { maxFuel = value; }
        }

        //Implement Interface property FuelPercentage{get;}
        public float FuelPercentage
        {
            get => (float)fuel / maxFuel * 100;
        }

        //Implement Interface Method to Refill()
        public void Refill(int amt)
        {
            fuel += amt;
            //Don't overfeed cat
            if (fuel > maxFuel)
            {
                fuel = maxFuel;
            }

        }

        //Ship ctor
        //Obviously includes parameters to pass to Vessel base class
        public Ship(int speed, string name, int fuel, int maxFuel) : base(speed, name)
        {
            this.fuel = fuel;
            this.maxFuel = maxFuel;
        }

        public override void Move()
        {
            //As per assignment guideline, if ship has fuel
            if(fuel > 0)
            {
                base.Speed = base.Speed;//Speed is as usual
            }
            else if(fuel == 0)//If no fuel
            {
                base.Speed = 0;//Can't move!
            }
            else//Something went wrong
            {
                throw new NotImplementedException();
            }
        }

        //Override to print Ship member variables
        public override string ToString()
        {
            return base.ToString() + $"Current Fuel: {fuel}\nMax Fuel: {maxFuel}\n";
        }
    }
}
