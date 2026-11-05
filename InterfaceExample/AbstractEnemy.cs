using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public abstract class AbstractEnemy
    {
        public string Name { get; set; }
        public int MaxHealth { get; set; }
        public int Health { get; set; }

        protected AbstractEnemy(string name, int maxHealth)
        {
            this.Name = name;
            this.MaxHealth = maxHealth;
            this.Health = this.MaxHealth;
        }

        // attack action
        // movement
        public virtual void Move()
        {
            // basic move functionality
            Console.WriteLine($"{Name} moves at an average pace.");
        }

        /*
         * public abstract void Move(); 
         * // this says any class inherited from this must provide a move function (once)
         */
        
        // loot
        // take damage

    }
}
