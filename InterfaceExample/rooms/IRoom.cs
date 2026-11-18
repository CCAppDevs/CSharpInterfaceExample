using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample.rooms
{
    public interface IRoom
    {
        public string Description { get; set; }
        public bool IsComplete { get; set; }
        public char RoomSymbol { get; set; }


        public void OnEnter();
        public void Interact();
        public void CompleteRoom();
        public void OnLeave();
    }
}
