﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheseusMinotaur
{
    class Game
    {
        Minotaur minotaur;
        Theseus theseus;
        //Tile[,] mapOne;
        Tile[,] theMap;
        Filer theFiler;

        
        /**** Map Constructor */
        /*
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
            theseus.SetGame(this);
            return theseus;
        }
        public Minotaur SetMinotaur(int newX, int newY)
        {
            minotaur = new Minotaur(newX, newY);
            minotaur.SetGame(this);
            return minotaur;
        }

        public void MapOne()
        {
            // create the map
            //Tile[,] 
            mapOne = CreateMap(4, 3);
            mapOne[0, 0].MyWalls = TheWalls.North | TheWalls.West;
            mapOne[1, 0].MyWalls = TheWalls.North | TheWalls.South;
            mapOne[2, 0].MyWalls = TheWalls.North | TheWalls.East;

            mapOne[0, 1].MyWalls = TheWalls.West;
            mapOne[1, 1].MyWalls = TheWalls.North | TheWalls.East | TheWalls.South;
            mapOne[2, 1].MyWalls = TheWalls.West;
            mapOne[3, 1].MyWalls = TheWalls.North | TheWalls.South | TheWalls.End;

            mapOne[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            mapOne[1, 2].MyWalls = TheWalls.South | TheWalls.North;
            mapOne[2, 2].MyWalls = TheWalls.South | TheWalls.East;

            // set positions of characters
            minotaur = SetMinotaur(1, 0);
            theseus = SetTheseus(1, 2);
        }
        */

        /**** Import Map from Filer */
        public void SetMap() //(int theMap)
        {
            theFiler = new Filer();
            theMap = theFiler.GetMapOne();
            SetTheseus(theFiler.GetTheseus());
            SetMinotaur(theFiler.GetMinotaur());
            //return theFiler.DrawMap();
        }

        internal void SetTheseus(Theseus newTheseus)
        {
            theseus = newTheseus;
            theseus.SetGame(this);
        }
        internal void SetMinotaur(Minotaur newMinotaur)
        {
            minotaur = newMinotaur;
            minotaur.SetGame(this);
        }

        public void DrawMap()
        {
            string output = "";
            int width = theMap.GetLength(0);
            int height = theMap.GetLength(1);


            for (int y = 0; y < height; y++)
            {
                for (int x = 0; x < width; x++)
                {
                    output += ".";
                    if (theMap[x, y].MyWalls.HasFlag(TheWalls.North))
                    {
                        output += "___";
                    }
                    else
                    {
                        output += "   ";
                    }

                }
                output += ".\n";



                for (int x = 0; x < width; x++)
                {
                    if (x != width - 1)
                    {
                        if (theMap[x, y].MyWalls.HasFlag(TheWalls.West) && !theMap[x, y].MyWalls.HasFlag(TheWalls.End))// && !mapOne[x, y].MyWalls.HasFlag(TheWalls.East) 
                        {
                            output += "|   ";
                        }
                        /*if (mapOne[x, y].MyWalls.HasFlag(TheWalls.West) && mapOne[x, y].MyWalls.HasFlag(TheWalls.East) && !mapOne[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "|   |";
                        }
                        if (!mapOne[x, y].MyWalls.HasFlag(TheWalls.West) && mapOne[x, y].MyWalls.HasFlag(TheWalls.East) && !mapOne[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "    |";
                        }*/
                        if (!theMap[x, y].MyWalls.HasFlag(TheWalls.West) && !theMap[x, y].MyWalls.HasFlag(TheWalls.End))// && !mapOne[x, y].MyWalls.HasFlag(TheWalls.East) 
                        {
                            output += "    ";
                        }

                        if (theMap[x, y].MyWalls.HasFlag(TheWalls.West) && !theMap[x, y].MyWalls.HasFlag(TheWalls.East) && theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "| X ";
                        }
                        if (theMap[x, y].MyWalls.HasFlag(TheWalls.West) && theMap[x, y].MyWalls.HasFlag(TheWalls.East) && theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "| X |";
                        }
                        if (!theMap[x, y].MyWalls.HasFlag(TheWalls.West) && theMap[x, y].MyWalls.HasFlag(TheWalls.East) && theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "  X |";
                        }
                        if (!theMap[x, y].MyWalls.HasFlag(TheWalls.West) && !theMap[x, y].MyWalls.HasFlag(TheWalls.East) && theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "  X ";
                        }
                    }

                    if (x == width - 1)
                    {
                        if (theMap[x, y].MyWalls.HasFlag(TheWalls.West) && !theMap[x, y].MyWalls.HasFlag(TheWalls.East) && !theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "|   ";
                        }
                        if (theMap[x, y].MyWalls.HasFlag(TheWalls.West) && theMap[x, y].MyWalls.HasFlag(TheWalls.East) && !theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "|   |";
                        }
                        if (!theMap[x, y].MyWalls.HasFlag(TheWalls.West) && theMap[x, y].MyWalls.HasFlag(TheWalls.East) && !theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "    |";
                        }
                        if (!theMap[x, y].MyWalls.HasFlag(TheWalls.West) && !theMap[x, y].MyWalls.HasFlag(TheWalls.East) && !theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "    ";
                        }

                        if (theMap[x, y].MyWalls.HasFlag(TheWalls.West) && !theMap[x, y].MyWalls.HasFlag(TheWalls.East) && theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "| X ";
                        }
                        if (theMap[x, y].MyWalls.HasFlag(TheWalls.West) && theMap[x, y].MyWalls.HasFlag(TheWalls.East) && theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "| X |";
                        }
                        if (!theMap[x, y].MyWalls.HasFlag(TheWalls.West) && theMap[x, y].MyWalls.HasFlag(TheWalls.East) && theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "  X |";
                        }
                        if (!theMap[x, y].MyWalls.HasFlag(TheWalls.West) && !theMap[x, y].MyWalls.HasFlag(TheWalls.East) && theMap[x, y].MyWalls.HasFlag(TheWalls.End))
                        {
                            output += "  X ";
                        }
                    }


                    if (x == minotaur.Coordinate.X && y == minotaur.Coordinate.Y)
                    {
                        StringBuilder newAscii = new StringBuilder(output);
                        newAscii[output.Length - 2] = 'M';
                        output = newAscii.ToString();
                    }
                    if (x == theseus.Coordinate.X && y == theseus.Coordinate.Y)
                    {
                        StringBuilder newAscii = new StringBuilder(output);
                        newAscii[output.Length - 2] = 'T';
                        output = newAscii.ToString();
                    }

                }
                output += "\n";

               
            }

            // lowest row of map
            for (int x = 0; x < width; x++)
            {
                output += ".";
                if (theMap[x, height - 1].MyWalls.HasFlag(TheWalls.South))
                {
                    output += "___";
                }
                else
                {
                    output += "   ";
                }
            }
            output += ".\n";


            /*
            if (column == Theseus.Position.X && row == Theseus.Position.Y)
            {
                StringBuilder newAscii = new StringBuilder(ascii);
                newAscii[ascii.Length - 3] = 'T';
                ascii = newAscii.ToString();
            }
            */


            Console.WriteLine(output);
        }



        /**** Get functions for Thing class */
        public Tile[,] GetMap()
        {
            return theMap;
        }
        
        public Theseus GetTheseus()
        {
            return theseus;
        }

        /**** Test functions */
        public String TestMap(Tile[,] aMap)
        {
            string output = "";
            foreach (Tile tile in aMap)
            {
                output += tile.Coordinate + " " + tile.MyWalls + "\n";
            }
            output += "minotaur " + minotaur.Coordinate + "\n" + "theseus " + theseus.Coordinate;
            return output;
        }

  
        /**** Game functions */

        // return the Player's move
        public Point PlayersTurn()
        {
            ConsoleKeyInfo theKey = Console.ReadKey();

            if (theKey.Key == ConsoleKey.UpArrow)
            {
                Console.WriteLine("Up");
                return Direction.Up;    
            }
            if (theKey.Key == ConsoleKey.DownArrow)
            {
                Console.WriteLine("Down");
                return Direction.Down;
            }
            if (theKey.Key == ConsoleKey.LeftArrow)
            {
                Console.WriteLine("Left");
                return Direction.Left;
            }
            if (theKey.Key == ConsoleKey.RightArrow)
            {
                Console.WriteLine("Right");
                return Direction.Right;
            }
            if (theKey.Key == ConsoleKey.A)
            {
                Console.WriteLine("Stayed still");
                return Direction.Pass;
            }
            return new Point();
        }

        public bool Move()
        {
            Point direction = PlayersTurn();
            if (direction != null)
            {
                return (theseus.Move(direction));
                
            }
            return false;
        }

        protected bool IsGameOver()
        {
            if (theseus.IsFinished() || minotaur.HasEaten())
            {
                return true;
            }
            return false;
        }


            /* The go button */
        public void Run()
        {
            Console.Clear();
            DrawMap();
            Console.WriteLine("Press Up, Down, Left, Right to move; Press A to do nothing");
            while (IsGameOver() == false)
                {
                    while (!Move())
                    {
                        Console.WriteLine("blocked");
                    }
                    minotaur.Hunt();
                    Console.Clear();
                    DrawMap();
                Console.WriteLine("Press Up, Down, Left, Right to move; Press A to do nothing");
                }
            if (IsGameOver() && theseus.IsFinished())
            {
                Console.WriteLine("Congrats!");
            }
            if (IsGameOver() && minotaur.HasEaten())
            {
                Console.WriteLine("Tastes like chicken");
                Console.WriteLine("Game over");
            }            
        }

    }
}
