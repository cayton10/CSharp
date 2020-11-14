using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Abstract class indicates Vessels are base classes only and
    //cannot be instantiated by themselves
    abstract public class Vessel : Object
    {
        //Required member variables
        private float speed;
        private string name;

        //Propfull method for getting/setting speed
        public float Speed
        {
            get { return speed; }
            set { speed = value; }
        }

        //Propfull method for setting/getting name
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //Vessel ctor
        public Vessel(float speed, string name)
        {
            this.speed = speed;
            this.name = name;
        }

        //Abstract Move method
        public abstract void Move();//Implementation of this abstract class
                                    //to be done in derived class definitions
                                    //Each derived class will use this method
                                    //differently

        //Override to print vessel member variables
        public override string ToString()
        {
            return $"Vessel speed: {speed},\nVessel name: {name}\n";
        }
    }
}
