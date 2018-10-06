using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    class Cat
    {
        public Cat(string name, string owner, double weight)
    :  base(name, owner, weight)
        {
        this.name = name;
        this.owner = owner;
        this.weight = weight;
        }
        public string meow(int count)
        {
        string meow = "";
        for (int i = 0; i < count; i++)
        {
            meow = meow + "meow.";
        }
        return meow;
        // put code to generate string here
    }

}
}
