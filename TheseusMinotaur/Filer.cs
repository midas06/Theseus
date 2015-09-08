using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheseusMinotaur
{
    class Filer
    {
        Tile[,] mapOne;
        Theseus theseus;
        Minotaur minotaur;

        public Tile[,] CreateMap(int newWidth, int newHeight)
        {
            Tile[,] Map;
            int width = newWidth, height = newHeight;
            Map = new Tile[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Map[x, y] = new Tile(x, y);
                }
            }
            return Map;
        }
        public Theseus SetTheseus(int newX, int newY)
        {
            theseus = new Theseus(newX, newY);
            //theseus.SetGame(this);
            return theseus;
        }
        public Minotaur SetMinotaur(int newX, int newY)
        {
            minotaur = new Minotaur(newX, newY);
            //minotaur.SetGame(this);
            return minotaur;
        }

        public Tile[,] GetMapOne()
        {
            // create the map
            //Tile[,] 
            mapOne = CreateMap(4, 3);
            mapOne[0, 0].MyWalls = TheWalls.North | TheWalls.West;
            mapOne[1, 0].MyWalls = TheWalls.North | TheWalls.South;
            mapOne[2, 0].MyWalls = TheWalls.North | TheWalls.East;
            mapOne[3, 0].MyWalls = TheWalls.West | TheWalls.South; // | TheWalls.East;

            mapOne[0, 1].MyWalls = TheWalls.West;
            mapOne[1, 1].MyWalls = TheWalls.North | TheWalls.East | TheWalls.South;
            mapOne[2, 1].MyWalls = TheWalls.West;
            mapOne[3, 1].MyWalls = TheWalls.North | TheWalls.South | TheWalls.End;

            mapOne[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            mapOne[1, 2].MyWalls = TheWalls.South | TheWalls.North;
            mapOne[2, 2].MyWalls = TheWalls.South | TheWalls.East;
            mapOne[3, 2].MyWalls = TheWalls.North | TheWalls.West;

            // set positions of characters
            minotaur = SetMinotaur(1, 0);
            theseus = SetTheseus(1, 2);
            return mapOne;
        }
        public Minotaur GetMinotaur()
        {
            return minotaur;
        }
        public Theseus GetTheseus()
        {
            return theseus;
        }

        

    }
}
