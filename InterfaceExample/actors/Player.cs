using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.actors
{
    public class Player : Character
    {
        public Player(string name, int positionX, int positionY, int maxHealth) : base(name, positionX, positionY, maxHealth)
        {
        }
    }
}
