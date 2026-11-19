using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.rooms
{
    public class LootRoom : IRoom
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public char RoomSymbol { get; set; }
        public List<Loot> Loots { get; set; }

        public LootRoom(List<Loot> loots)
        {
            this.Loots = loots;
            RoomSymbol = 'L';
            IsComplete = false;
            Description = "You find a large pile of treasure!";
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
