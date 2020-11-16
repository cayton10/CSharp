using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoList
{
    public class Activity
    {
        //Private member variables
        private string name;
        private DateTime date;

        //Property accessors
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        

        //Object constructor
        public Activity(string name, DateTime date)
        {
            Name = name;
            Date = date;
        }

        //ToString override
        public override string ToString()
        {
            return $"{name}-{date}";
        }

        

    }
}
