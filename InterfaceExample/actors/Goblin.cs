using InterfaceExample.architecture;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.actors
{
    public class Goblin : AbstractEnemy, IFleeable
    {
        public Goblin(string name, int x, int y, int maxHealth) : base(name, x, y, maxHealth)
        {
        }

        public bool Flee()
        {
            Console.WriteLine($"{Name} flees the combat!");
            return true;
        }

        public override void Move(int x, int y)
        {
            // basic move functionality
            Console.WriteLine($"{Name} moves at an average pace.");
        }
    }
}
