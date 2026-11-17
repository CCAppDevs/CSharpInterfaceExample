using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.actors
{
    public class Wizard : AbstractEnemy
    {
        public Wizard(string name, int x, int y, int maxHealth) : base(name, x, y, maxHealth)
        {
        }

        public override void Move(int x, int y)
        {
            Console.WriteLine($"{Name} teleports forward at an alarming pace!");
        }
    }
}
