using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class Wizard : AbstractEnemy
    {
        public Wizard(string name, int maxHealth) : base(name, maxHealth)
        {
        }

        public override void Move()
        {
            Console.WriteLine($"{Name} teleports forward at an alarming pace!");
        }
    }
}
