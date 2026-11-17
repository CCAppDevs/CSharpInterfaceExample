using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExample
{
    public class Map
    {
        private List<List<string>> _rooms;
        private int _sizeX;
        private int _sizeY;

        public Map(int width, int height)
        {
            this._sizeX = width;
            this._sizeY = height;
            this._rooms = new List<List<string>>();

            for(int y = 0; y < this._sizeY; y++)
            {
                this._rooms.Add(new List<string>());
                for (int x = 0; x < this._sizeX; x++)
                {
                    this._rooms[y].Add($"{x},{y}");
                }
            }
        }
    }
}
