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
        private Random _rand;

        public Map(int width, int height, Random rand)
        {
            this._sizeX = width;
            this._sizeY = height;
            this._rooms = new List<List<IRoom>>();
            this._rand = rand;

            for (int y = 0; y < this._sizeY; y++)
            {
                this._rooms.Add(new List<IRoom>());
                for (int x = 0; x < this._sizeX; x++)
                {
                    int roll = this._rand.Next(0, 100);

                    if (roll < 5)
                    {
                        // loot room
                        this._rooms[y].Add(new LootRoom(new List<Loot> {
                            new Loot(),
                            new Loot()
                        }));
                    }
                    else if (roll < 15)
                    {
                        // monster room
                        this._rooms[y].Add(new MonsterRoom(new Wizard("Bob", x, y, 100)));
                    }
                    else
                    {
                        this._rooms[y].Add(new EmptyRoom());
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
