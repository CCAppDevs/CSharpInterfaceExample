using InterfaceExample.actors;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.rooms
{
    public class MonsterRoom : IRoom
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public char RoomSymbol { get; set; }
        public AbstractEnemy Monster { get; set; }

        public MonsterRoom(AbstractEnemy monster)
        {
            this.Monster = monster;
            this.Description = "This room contains monsters!";
            this.IsComplete = false;
            this.RoomSymbol = 'M';
        }

        public void CompleteRoom()
        {
            throw new NotImplementedException();
        }

        public void Interact()
        {
            throw new NotImplementedException();
        }

        public void OnEnter()
        {
            throw new NotImplementedException();
        }

        public void OnLeave()
        {
            throw new NotImplementedException();
        }
    }
}
