using System;
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
        Tile[,] theMap;
        Filer theFiler;
        int currentMap;

        /**** Import Map from Filer */

        public void SetMap(int aMap)
        {
            currentMap = aMap;
            theFiler = new Filer();
            theFiler.Init();
            theMap = theFiler.GetMap(aMap);
            SetTheseus(theFiler.GetTheseus());
            SetMinotaur(theFiler.GetMinotaur());
        }

        public void Restart()
        {
            theMap = theFiler.GetMap(currentMap);
            SetTheseus(theFiler.GetTheseus());
            SetMinotaur(theFiler.GetMinotaur());
            Run();
        }

        protected void SetTheseus(Theseus newTheseus)
        {
            theseus = newTheseus;
            theseus.SetGame(this);
        }
        protected void SetMinotaur(Minotaur newMinotaur)
        {
            minotaur = newMinotaur;
            minotaur.SetGame(this);
        }

        protected void DrawMap()
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
                        StringBuilder minoPosition = new StringBuilder(output);
                        minoPosition[output.Length - 2] = 'M';
                        output = minoPosition.ToString();
                    }
                    if (x == theseus.Coordinate.X && y == theseus.Coordinate.Y)
                    {
                        StringBuilder thesPosition = new StringBuilder(output);
                        thesPosition[output.Length - 2] = 'T';
                        output = thesPosition.ToString();
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


            Console.WriteLine(output);
        }



        /**** Get functions for Thing class */
        internal Tile[,] GetMap()
        {
            return theMap;
        }

        internal Theseus GetTheseus()
        {
            return theseus;
        }

        /**** Test functions */
        protected String TestMap(Tile[,] aMap)
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
        protected Point PlayersTurn()
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

        protected bool Move()
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
        public bool Run()
        {
            Console.Clear();
            DrawMap();
            while (IsGameOver() == false)
            {
                Console.WriteLine("Press Up, Down, Left, Right to move; Press A to do nothing");
                while (!Move())
                {
                    Console.WriteLine("blocked");
                }
                if (!theseus.IsFinished())
                {
                    minotaur.Hunt();

                }
                Console.Clear();
                DrawMap();

            }
            if (IsGameOver() && theseus.IsFinished())
            {
                Console.WriteLine("Congrats!");
                return false;
            }
            if (IsGameOver() && minotaur.HasEaten())
            {
                Console.WriteLine("Tastes like chicken");
                Console.WriteLine("Game over");
                return false;
            }
            return true;
        }


    }
}
