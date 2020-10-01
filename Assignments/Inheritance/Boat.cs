using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Boat inherits Vessel
    public class Boat : Vessel
    {
        private int oars;

        public int Oars
        {
            get {return oars;}
            set {oars = value;}
        }

        public Boat(float speed, string name, int oars): base(speed, name)
        {
            this.oars = oars;
        }

        public override void Move()
        {
            if(oars < 0)
            {
                base.Speed = 0;
            }
            else if(oars >= 0)
            {
                base.Speed *= oars;//Base speed x # of oars
            }
            else
                throw new NotImplementedException("No oars on this boat!");
        }

        //Override to print Boat member variables
        public override string ToString()
        {
            return base.ToString() + $"Number of Oars: {oars}\n";
        }
    }
}
