using InterfaceExample.architecture;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.actors
{
    public class Goblin : Character, IFleeable
    {
        public Goblin(string name, int x, int y, int maxHealth) : base(name, x, y, maxHealth)
        {
        }

        public bool Flee()
        {
            Console.WriteLine($"{Name} flees the combat!");
            return true;
        }
    }
}
