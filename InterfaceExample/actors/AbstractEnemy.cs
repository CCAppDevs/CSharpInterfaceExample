using InterfaceExample.architecture;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.actors
{
    public abstract class AbstractEnemy : Actor, IHealth
    {
        protected AbstractEnemy(string name, int positionX, int positionY, int maxHealth) : 
            base(name, positionX, positionY)
        {
            MaxHealth = maxHealth;
            Health = MaxHealth;
        }

        public int MaxHealth { get; set; }
        public int Health { get; set; }

        public bool IsAlive()
        {
            return Health > 0;
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
