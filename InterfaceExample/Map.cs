using InterfaceExample.actors;
using InterfaceExample.rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class Map
    {
        private List<List<IRoom>> _rooms;
        private int _sizeX;
        private int _sizeY;

        public Map(int width, int height)
        {
            this._sizeX = width;
            this._sizeY = height;
            this._rooms = new List<List<IRoom>>();

            for(int y = 0; y < this._sizeY; y++)
            {
                this._rooms.Add(new List<IRoom>());
                for (int x = 0; x < this._sizeX; x++)
                {
                    if (x % 2 == 0)
                    {
                        this._rooms[y].Add(new EmptyRoom());
                    }
                    else
                    {
                        this._rooms[y].Add(new MonsterRoom(new Wizard("Bob", x, y, 100)));
                    }
                    
                }
            }
        }

        public void PrintMap()
        {
            for (int y = 0; y < this._sizeY; y++)
            {
                for (int x = 0; x < this._sizeX; x++)
                {
                    Console.Write($"[{ this._rooms[y][x].RoomSymbol }]");
                }
                Console.WriteLine();
            }
        }
    }
}
