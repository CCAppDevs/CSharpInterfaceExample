using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class Goblin : AbstractEnemy, IFleeable
    {
        public Goblin(string name, int maxHealth) : base(name, maxHealth)
        {
        }

        public bool Flee()
        {
            Console.WriteLine($"{Name} flees the combat!");
            return true;
        }
    }
}
