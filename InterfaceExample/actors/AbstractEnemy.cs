using InterfaceExample.architecture;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.actors
{
    public abstract class AbstractEnemy : Actor, IHealth, IHitBox, IHurtBox, IMovement
    {
        protected AbstractEnemy(string name, int positionX, int positionY, int maxHealth) : 
            base(name, positionX, positionY)
        {
            MaxHealth = maxHealth;
            Health = MaxHealth;
        }

        public int MaxHealth { get; set; }
        private int _health;
        public int Health { 
            get
            {
                return _health;
            }
            set
            {
                if (value < 0)
                {
                    _health = 0;
                }
                else if (value > MaxHealth)
                {
                    _health = MaxHealth;
                }
                else
                {
                    _health = value;
                }
            } 
        }

        public bool ApplyDamage(IHurtBox source, int amount)
        {
            this.Health = this.Health - amount;
            return true;
        }

        public bool DealDamage(IHitBox target, int amount)
        {
            // TODO: show a hit has happened
            return target.ApplyDamage(this, amount);
        }

        public bool IsAlive()
        {
            return Health > 0;
        }

        public abstract void Move(int x, int y);



        // loot

    }
}
