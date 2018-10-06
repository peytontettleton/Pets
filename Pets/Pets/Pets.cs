using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Pets
    {
        public string type { set; get; }
        public string name { set; get; }
        public string owner { set; get; }
        public double weight { set; get; }

        public Pet(string type, string name, string owner, double weight)
        {
            this.type = type;
            this.name = name;
            this.owner = owner;
            this.weight = weight;
        }

        public string getTag()
        {
            return "If lost, call" + this.owner + ".";
        }
    }
}
