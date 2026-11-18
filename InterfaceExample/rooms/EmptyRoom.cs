using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.rooms
{
    public class EmptyRoom : IRoom
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public char RoomSymbol { get; set; }

        public EmptyRoom()
        {
            IsComplete = true;
            Description = "You walk into an empty room.";
            RoomSymbol = ' ';
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
