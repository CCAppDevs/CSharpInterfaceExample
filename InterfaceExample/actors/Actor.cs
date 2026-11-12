using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.actors
{
    public class Actor
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public string Name { get; set; }

        public Actor(string name, int positionX, int positionY)
        {
            this.PositionX = positionX;
            this.PositionY = positionY;
            this.Name = name;
        }
    }
}
