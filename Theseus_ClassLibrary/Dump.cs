using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Theseus_ClassLibrary
{
    class Dump
    {
        Filer theFiler;
        // TO DELETE 

        public bool NorthWallHasExit(Tile[,] aMap)
        {
            int width, height;
            width = aMap.GetLength(0);
            height = aMap.GetLength(1);
            for (int i = 0; i < width; i++)
            {
                if (aMap[i, 0].MyWalls.HasFlag(TheWalls.End))
                {
                    return true;
                }
            }
            return false;
        }
        public bool SouthWallHasExit(Tile[,] aMap)
        {
            int width, height;
            width = aMap.GetLength(0);
            height = aMap.GetLength(1);
            for (int i = 0; i < width; i++)
            {
                if (aMap[i, (height - 1)].MyWalls.HasFlag(TheWalls.End))
                {
                    return true;
                }
            }
            return false;
        }
        public bool WestWallHasExit(Tile[,] aMap)
        {
            int width, height;
            width = aMap.GetLength(0);
            height = aMap.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                if (aMap[0, i].MyWalls.HasFlag(TheWalls.End))
                {
                    return true;
                }
            }
            return false;
        }
        public bool EastWallHasExit(Tile[,] aMap)
        {
            int width, height;
            width = aMap.GetLength(0);
            height = aMap.GetLength(1);
            for (int i = 0; i < height; i++)
            {
                if (aMap[(width - 1), i].MyWalls.HasFlag(TheWalls.End))
                {
                    return true;
                }
            }
            return false;
        }


        public void TestOuterWalls(Tile[,] aMap)
        {
            int width, height, leftWall = 50, rightWall = 50, topWall = 50, bottomWall = 50;
            width = aMap.GetLength(0);
            height = aMap.GetLength(1);

            // determine where the exit is

            if (NorthWallHasExit(aMap))
            {
                topWall = 1;
            }
            else
            {
                topWall = 0;
            }

            if (SouthWallHasExit(aMap))
            {
                bottomWall = height - 2;
            }
            else
            {
                bottomWall = height - 1;
            }


            if (WestWallHasExit(aMap))
            {
                leftWall = 1;
            }
            else
            {
                leftWall = 0;
            }

            if (EastWallHasExit(aMap))
            {
                rightWall = width - 2;
            }
            else
            {
                rightWall = width - 1;
            }

            string corners = "";
            corners += "Top: " + topWall.ToString() + "\nBottom: " + bottomWall.ToString() + "\nLeft: " + leftWall.ToString() + "\nRight: " + rightWall.ToString();
            Console.WriteLine(corners);




        }

        public int[] GetOuterWallArray(Tile[,] aMap)
        {
            int width, height, leftWall = 50, rightWall = 50, topWall = 50, bottomWall = 50;
            width = aMap.GetLength(0);
            height = aMap.GetLength(1);
            int[] theWallArray = new int[4];

            // determine where the exit is

            if (NorthWallHasExit(aMap))
            {
                topWall = 1;
            }
            else
            {
                topWall = 0;
            }

            if (SouthWallHasExit(aMap))
            {
                bottomWall = height - 2;
            }
            else
            {
                bottomWall = height - 1;
            }


            if (WestWallHasExit(aMap))
            {
                leftWall = 1;
            }
            else
            {
                leftWall = 0;
            }

            if (EastWallHasExit(aMap))
            {
                rightWall = width - 2;
            }
            else
            {
                rightWall = width - 1;
            }

            string corners = "";
            corners += "Top: " + topWall.ToString() + "\nBottom: " + bottomWall.ToString() + "\nLeft: " + leftWall.ToString() + "\nRight: " + rightWall.ToString();
            Console.WriteLine(corners);

            theWallArray[0] = topWall;
            theWallArray[1] = rightWall;
            theWallArray[2] = bottomWall;
            theWallArray[3] = leftWall;

            return theWallArray;



        }

        /*
        public void EastWallBroken(Tile[,] aMap)
        {
            int[] theWallArray = GetOuterWallArray(aMap);

            if (!EastWallHasExit(aMap))
            {
                for (int i = 0; i <= theWallArray[2]; i++)
                {
                    if (!aMap[theWallArray[1], i].MyWalls.HasFlag(TheWalls.East))
                    {
                        Console.WriteLine("East wall broken");
                    }
                }
            }
            if (EastWallHasExit(aMap))
            {
                for (int i = 0; i <= theWallArray[2]; i++)
                {
                    if (!aMap[theWallArray[1], i].MyWalls.HasFlag(TheWalls.East))
                    {
                        if (!aMap[theWallArray[1] + 1, i].MyWalls.HasFlag(TheWalls.End))
                        {
                            Console.WriteLine("East wall broken");

                        }
                    }
                }
            }
            //return false;
        }

        public void SouthWallBroken(Tile[,] aMap)
        {
            int[] theWallArray = GetOuterWallArray(aMap);
            int width, height;
            width = aMap.GetLength(0);
            height = aMap.GetLength(1);

            if (!SouthWallHasExit(aMap))
            {
                for (int i = 0; i < theWallArray[1]; i++)
                {
                    if (!aMap[i, theWallArray[2]].MyWalls.HasFlag(TheWalls.South))
                    {
                        //return true;
                        Console.WriteLine("South wall broken");
                    }
                }
            }
            if (SouthWallHasExit(aMap))
            {
                for (int i = 0; i <= theWallArray[1]; i++)
                {
                    if (!aMap[i, theWallArray[2]].MyWalls.HasFlag(TheWalls.South))
                    {
                        if (!aMap[i, theWallArray[2] + 1].MyWalls.HasFlag(TheWalls.End))
                        {
                            //return true;
                            Console.WriteLine("South wall broken");

                        }
                    }
                }
            }
           // return false;
        }
        public void NorthWallBroken(Tile[,] aMap)
        {
            int[] theWallArray = GetOuterWallArray(aMap);


            if (!NorthWallHasExit(aMap))
            {
                for (int i = 0; i < theWallArray[1]; i++)
                {
                    if (!aMap[i,theWallArray[0]].MyWalls.HasFlag(TheWalls.North))
                    {
                        //return true;
                        Console.WriteLine("North wall broken");
                    }
                }
            }
            if (NorthWallHasExit(aMap))
            {
                for (int i = 0; i <= theWallArray[1]; i++)
                {
                    if (!aMap[i, theWallArray[0]].MyWalls.HasFlag(TheWalls.North))
                    {
                        if (!aMap[i, theWallArray[0] - 1].MyWalls.HasFlag(TheWalls.End))
                        {
                            // return true;
                            Console.WriteLine("North wall broken");
                        }
                    }
                }
            }
            //return false;
        }

        public void WestWallBroken(Tile[,] aMap)
        {
            int[] theWallArray = GetOuterWallArray(aMap);

            if (!WestWallHasExit(aMap))
            {
                for (int i = 0; i <= theWallArray[2]; i++)
                {
                    if (!aMap[theWallArray[3], i].MyWalls.HasFlag(TheWalls.West))
                    {
                        Console.WriteLine("West wall broken");
                    }
                }
            }
            if (WestWallHasExit(aMap))
            {
                for (int i = 0; i <= theWallArray[2]; i++)
                {
                    if (!aMap[theWallArray[3], i].MyWalls.HasFlag(TheWalls.West))
                    {
                        if (!aMap[theWallArray[3] - 1, i].MyWalls.HasFlag(TheWalls.End))
                        {
                            Console.WriteLine("West wall broken");

                        }
                    }
                }
            }
            //return false;
        }
        */

        public bool EastWallBroken(Tile[,] aMap)
        {
            int[] theWallArray = GetOuterWallArray(aMap);

            if (!EastWallHasExit(aMap))
            {
                if (!NorthWallHasExit(aMap) && !SouthWallHasExit(aMap))
                {
                    for (int i = 0; i <= theWallArray[2]; i++)
                    {
                        if (!aMap[theWallArray[1], i].MyWalls.HasFlag(TheWalls.East))
                        {
                            return true;
                        }
                    }
                }

                if (NorthWallHasExit(aMap))
                {
                    for (int i = 1; i <= theWallArray[2]; i++)
                    {
                        if (!aMap[theWallArray[1], i].MyWalls.HasFlag(TheWalls.East))
                        {
                            return true;
                        }
                    }
                }
                if (SouthWallHasExit(aMap))
                {
                    for (int i = 0; i <= theWallArray[2] - 1; i++)
                    {
                        if (!aMap[theWallArray[1], i].MyWalls.HasFlag(TheWalls.East))
                        {
                            return true;
                        }
                    }
                }

            }
            if (EastWallHasExit(aMap))
            {
                for (int i = 0; i <= theWallArray[2]; i++)
                {
                    if (!aMap[theWallArray[1], i].MyWalls.HasFlag(TheWalls.East))
                    {
                        if (!aMap[theWallArray[1] + 1, i].MyWalls.HasFlag(TheWalls.End))
                        {
                            return true;

                        }
                    }
                }
            }
            return false;
        }

        public bool SouthWallBroken(Tile[,] aMap)
        {
            int[] theWallArray = GetOuterWallArray(aMap);


            if (!SouthWallHasExit(aMap))
            {
                if (!WestWallHasExit(aMap) && !EastWallHasExit(aMap))
                {
                    for (int i = 0; i <= theWallArray[1]; i++)
                    {
                        if (!aMap[i, theWallArray[2]].MyWalls.HasFlag(TheWalls.South))
                        {
                            return true;
                        }
                    }
                }

                if (WestWallHasExit(aMap))
                {
                    for (int i = 1; i <= theWallArray[1]; i++)
                    {
                        if (!aMap[i, theWallArray[2]].MyWalls.HasFlag(TheWalls.South))
                        {
                            return true;
                        }
                    }
                }

                if (EastWallHasExit(aMap))
                {
                    for (int i = 0; i <= theWallArray[1] - 1; i++)
                    {
                        if (!aMap[i, theWallArray[2]].MyWalls.HasFlag(TheWalls.South))
                        {
                            return true;
                        }
                    }
                }

            }
            if (SouthWallHasExit(aMap))
            {
                for (int i = 0; i <= theWallArray[1]; i++)
                {
                    if (!aMap[i, theWallArray[2]].MyWalls.HasFlag(TheWalls.South))
                    {
                        if (!aMap[i, theWallArray[2] + 1].MyWalls.HasFlag(TheWalls.End))
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public void TestEastWalls()
        {
            string results = "";
            for (int i = 0; i < theFiler.allMyMaps.Length; i++)
            {
                if (theFiler.allMyMaps[i] != null)
                {
                    if (EastWallBroken(theFiler.allMyMaps[i]))
                    {
                        results += "Map " + i.ToString() + "is broken\n";
                    }
                }
            }

            Console.WriteLine(results);

        }

        public void TestSouthWalls()
        {
            string results = "";
            for (int i = 0; i < theFiler.allMyMaps.Length; i++)
            {
                if (theFiler.allMyMaps[i] != null)
                {
                    if (SouthWallBroken(theFiler.allMyMaps[i]))
                    {
                        results += "Map " + i.ToString() + "is broken\n";
                    }
                }
            }

            Console.WriteLine(results);

        }
        public void TestCorners(Tile[,] aMap)
        {
            int[] theWallArray = GetOuterWallArray(aMap);
            if (aMap[theWallArray[3], theWallArray[0]].MyWalls.HasFlag(TheWalls.North) && aMap[theWallArray[3], theWallArray[0]].MyWalls.HasFlag(TheWalls.West))
            {
                Console.WriteLine("Top left corner fine");
            }
            else if (!aMap[theWallArray[3], theWallArray[0]].MyWalls.HasFlag(TheWalls.North) || !aMap[theWallArray[3], theWallArray[0]].MyWalls.HasFlag(TheWalls.West))
            {
                Console.WriteLine("Top left corner broken");
            }

            if (aMap[theWallArray[3], theWallArray[2]].MyWalls.HasFlag(TheWalls.South) && aMap[theWallArray[3], theWallArray[2]].MyWalls.HasFlag(TheWalls.West))
            {
                Console.WriteLine("Bottom left corner fine");
            }
            else if (!aMap[theWallArray[3], theWallArray[2]].MyWalls.HasFlag(TheWalls.South) || !aMap[theWallArray[3], theWallArray[2]].MyWalls.HasFlag(TheWalls.West))
            {
                Console.WriteLine("Bottom left corner broken");
            }


            if (aMap[theWallArray[1], theWallArray[0]].MyWalls.HasFlag(TheWalls.North) && aMap[theWallArray[1], theWallArray[0]].MyWalls.HasFlag(TheWalls.East))
            {
                Console.WriteLine("Top right corner fine");
            }
            else if (!aMap[theWallArray[1], theWallArray[0]].MyWalls.HasFlag(TheWalls.North) || !aMap[theWallArray[1], theWallArray[0]].MyWalls.HasFlag(TheWalls.East))
            {
                Console.WriteLine("Top Right corner broken");
            }

            if (aMap[theWallArray[1], theWallArray[2]].MyWalls.HasFlag(TheWalls.South) && aMap[theWallArray[1], theWallArray[2]].MyWalls.HasFlag(TheWalls.East))
            {
                Console.WriteLine("Bottom right corner fine");
            }
            else if (!aMap[theWallArray[1], theWallArray[2]].MyWalls.HasFlag(TheWalls.South) || !aMap[theWallArray[1], theWallArray[2]].MyWalls.HasFlag(TheWalls.East))
            {
                Console.WriteLine("Bottom right corner broken");
            }
        }

        public void TestInnerTiles(Tile[,] aMap)
        {
            int[] theWallArray = GetOuterWallArray(aMap);
            int top, right, left, bottom;
            top = theWallArray[0];
            right = theWallArray[1];
            bottom = theWallArray[2];
            left = theWallArray[3];

            for (int x = left + 1; x < right; x++)
            {
                for (int y = top + 1; y < bottom; y++)
                {
                    if (aMap[x, y].MyWalls.HasFlag(TheWalls.North) && !aMap[x, y - 1].MyWalls.HasFlag(TheWalls.South))
                    {
                        Console.WriteLine("Broken tile (north south)");
                    }
                    if (aMap[x, y].MyWalls.HasFlag(TheWalls.South) && !aMap[x, y + 1].MyWalls.HasFlag(TheWalls.North))
                    {
                        Console.WriteLine("Broken tile (south north)");
                    }
                    if (aMap[x, y].MyWalls.HasFlag(TheWalls.East) && !aMap[x + 1, y].MyWalls.HasFlag(TheWalls.West))
                    {
                        Console.WriteLine("Broken tile (east west)");
                    }
                    if (aMap[x, y].MyWalls.HasFlag(TheWalls.West) && !aMap[x - 1, y].MyWalls.HasFlag(TheWalls.East))
                    {
                        Console.WriteLine("broken tile (west east)");
                    }

                }
            }


        }

        public bool AreInnerTilesBroken(Tile[,] aMap)
        {
            int[] theWallArray = GetOuterWallArray(aMap);
            int top, right, left, bottom;
            top = theWallArray[0];
            right = theWallArray[1];
            bottom = theWallArray[2];
            left = theWallArray[3];

            for (int x = left + 1; x < right; x++)
            {
                for (int y = top + 1; y < bottom; y++)
                {
                    if (aMap[x, y].MyWalls.HasFlag(TheWalls.North) && !aMap[x, y - 1].MyWalls.HasFlag(TheWalls.South))
                    {
                        Console.WriteLine("Broken tile: " + x + y + " NS");
                        return true;
                    }
                    if (aMap[x, y].MyWalls.HasFlag(TheWalls.South) && !aMap[x, y + 1].MyWalls.HasFlag(TheWalls.North))
                    {
                        Console.WriteLine("Broken tile: " + x + y + " SN");
                        return true;
                    }
                    if (aMap[x, y].MyWalls.HasFlag(TheWalls.East) && !aMap[x + 1, y].MyWalls.HasFlag(TheWalls.West))
                    {
                        Console.WriteLine("Broken tile: " + x + y + " EW");
                        return true;
                    }
                    if (aMap[x, y].MyWalls.HasFlag(TheWalls.West) && !aMap[x - 1, y].MyWalls.HasFlag(TheWalls.East))
                    {
                        Console.WriteLine("Broken tile: " + x + y + " WE");
                        return true;
                    }
                }
            }
            return false;

        }

        public void TestAllInnerTiles()
        {
            string results = "";
            for (int i = 0; i < theFiler.allMyMaps.Length; i++)
            {
                if (theFiler.allMyMaps[i] != null)
                {
                    if (AreInnerTilesBroken(theFiler.allMyMaps[i]))
                    {
                        results += "Map " + i.ToString() + "is broken\n";
                    }
                }
            }

            Console.WriteLine(results);
        }

        /***** FROM FILER *****/
        /*** TO DELETE ****/
        // testing movement of Theseus
        /*
        protected void SetTestMapOne()
        {
            theMap = CreateMap(4, 3);

            for (int i = 0; i < 4; i++)
            {
                theMap[i, 0].MyWalls = TheWalls.North;
                theMap[i, 2].MyWalls = TheWalls.South;
            }

            for (int i = 0; i < 3; i++)
            {
                theMap[0, i].MyWalls = TheWalls.West;
                theMap[2, i].MyWalls = TheWalls.East;
                theMap[3, i].MyWalls = TheWalls.West | TheWalls.East;
            }

            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.West;
            theMap[0, 2].MyWalls = TheWalls.South | TheWalls.West;
            theMap[2, 0].MyWalls = TheWalls.North | TheWalls.East;
            theMap[2, 2].MyWalls = TheWalls.South | TheWalls.East;
            theMap[3, 1].MyWalls = TheWalls.North | TheWalls.East | TheWalls.West | TheWalls.South;
            theMap[3, 0].MyWalls = TheWalls.South;
            theMap[3, 2].MyWalls = TheWalls.North;


            allMyMaps[9] = theMap;
        }*//*
        protected void SetTestMapOne()
        {
            theMap = CreateMap(5, 4);

            for (int i = 0; i < 4; i++)
            {
                theMap[i, 0].MyWalls = TheWalls.North;
                theMap[i, 3].MyWalls = TheWalls.South;
            }

            for (int i = 0; i < 4; i++)
            {
                if (i != 2)
                {
                    theMap[0, i].MyWalls = TheWalls.West;
                    theMap[3, i].MyWalls = TheWalls.East;
                }
            }

            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.West; // TheWalls.West;// 
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West; //TheWalls.West; // TheWalls.South | TheWalls.West;
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.East;
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.East;
            theMap[4, 2].MyWalls = TheWalls.North | TheWalls.South | TheWalls.End;
            theMap[4, 1].MyWalls = TheWalls.West | TheWalls.South;
            theMap[4, 3].MyWalls = TheWalls.West | TheWalls.North;

            theMap[1, 1].MyWalls = TheWalls.North | TheWalls.East | TheWalls.South | TheWalls.West;
            theMap[1, 0].MyWalls = TheWalls.North | TheWalls.South;
            theMap[1, 2].MyWalls = TheWalls.North;
            theMap[2, 1].MyWalls = TheWalls.West;
            theMap[0, 1].MyWalls = TheWalls.East | TheWalls.West;


            allMyMaps[9] = theMap;
        }
        */
    }
}
