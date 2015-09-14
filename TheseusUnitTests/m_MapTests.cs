using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Theseus_ClassLibrary;

namespace TheseusUnitTests
{
    [TestClass]
    public class m_MapTests
    {

        /*
        [TestMethod]
        public void m_MapTest_HasExitTile_testMap1()
        {
            Game aGame = new Game();
            aGame.SetTestMap(1);
            Tile[,] theMap = aGame.GetMap();
            bool expected, actual;
            expected = false;
            actual = true;

            // test of the test method, expect false

            if (aGame.HasExitTile(theMap) == false)
            {
                actual = false;
            }

            Assert.AreEqual(expected, actual, "The map does not have an exit tile");

        }
         * 
         * */
        [TestMethod]
        public void m_MapTest_HasExitTile_allMaps()
        {
            Game aGame = new Game();
            aGame.SetMap(1);
            Tile[,] theMap;
            Tile [][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = true;
            actual = true;

            


            // return true if one tile is the exit, else return false

            for (int i = 0;  i < allTheMaps.Length; i++)
            {
                if (allTheMaps[i] != null)
                {
                    theMap = allTheMaps[i];
                    if (aGame.HasExitTile(theMap) == false)
                    {
                        actual = false;
                    }
                }                   
            }
            Assert.AreEqual(expected, actual, "One of the maps does not have an exit tile");
        }

        /*
        [TestMethod]
        public void m_MapTest_NorthWallBroken_testMap3()
        {
            // test of the test method, should return true

            Game aGame = new Game();
            aGame.SetTestMap(3);
            Tile[,] theMap = aGame.GetMap();
            //Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = true;

            actual = aGame.NorthWallBroken(theMap);




            Assert.AreEqual(expected, actual, "The wall is not being detected as being broken");
        }
        
        [TestMethod]
        public void m_MapTest_SouthWallBroken_testMap3()
        {
            // test of the test method, should return true

            Game aGame = new Game();
            aGame.SetTestMap(3);
            Tile[,] theMap = aGame.GetMap();
            //Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = true;

            actual = aGame.SouthWallBroken(theMap);




            Assert.AreEqual(expected, actual, "The wall is not being detected as being broken");
        }

        [TestMethod]
        public void m_MapTest_EastWallBroken_testMap3()
        {
            // test of the test method, should return true

            Game aGame = new Game();
            aGame.SetTestMap(3);
            Tile[,] theMap = aGame.GetMap();
            //Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = true;

            actual = aGame.EastWallBroken(theMap);




            Assert.AreEqual(expected, actual, "The wall is not being detected as being broken");
        }

        [TestMethod]
        public void m_MapTest_WestWallBroken_testMap3()
        {
            // test of the test method, should return true

            Game aGame = new Game();
            aGame.SetTestMap(3);
            Tile[,] theMap = aGame.GetMap();
            //Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = true;

            actual = aGame.WestWallBroken(theMap);




            Assert.AreEqual(expected, actual, "The wall is not being detected as being broken");
        }
        */
        [TestMethod]
        public void m_MapTest_NorthWallBroken_AllMaps()
        {
            Game aGame = new Game();
            aGame.SetMap(1);
            Tile[,] theMap;
            Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = false;
            actual = false;

            // return true if one North wall is broken

            for (int i = 0; i < allTheMaps.Length; i++)
            {
                if (allTheMaps[i] != null)
                {
                    theMap = allTheMaps[i];
                    if (aGame.NorthWallBroken(theMap) == true)
                    {
                        actual = true;
                    }
                }
            }



            Assert.AreEqual(expected, actual, "One of the North walls is broken");
        }

        [TestMethod]
        public void m_MapTest_EastWallBroken_AllMaps()
        {
 
            Game aGame = new Game();
            aGame.SetMap(1);
            Tile[,] theMap;
            Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = false;
            actual = false;

            // return true if one East wall is broken

            for (int i = 0; i < allTheMaps.Length; i++)
            {
                if (allTheMaps[i] != null)
                {
                    theMap = allTheMaps[i];
                    if (aGame.EastWallBroken(theMap) == true)
                    {
                        actual = true;
                    }
                }
            }



            Assert.AreEqual(expected, actual, "One of the East walls is broken");
        }

        [TestMethod]
        public void m_MapTest_SouthWallBroken_AllMaps()
        {
            Game aGame = new Game();
            aGame.SetMap(1);
            Tile[,] theMap;
            Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = false;
            actual = false;

            // return true if one South wall is broken

            for (int i = 0; i < allTheMaps.Length; i++)
            {
                if (allTheMaps[i] != null)
                {
                    theMap = allTheMaps[i];
                    if (aGame.SouthWallBroken(theMap) == true)
                    {
                        actual = true;
                    }
                }
            }



            Assert.AreEqual(expected, actual, "One of the South walls is broken");
        }

        [TestMethod]
        public void m_MapTest_WestWallBroken_AllMaps()
        {
            Game aGame = new Game();
            aGame.SetMap(1);
            Tile[,] theMap;
            Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = false;
            actual = false;

            // return true if one West wall is broken

            for (int i = 0; i < allTheMaps.Length; i++)
            {
                if (allTheMaps[i] != null)
                {
                    theMap = allTheMaps[i];
                    if (aGame.WestWallBroken(theMap) == true)
                    {
                        actual = true;
                    }
                }
            }
            Assert.AreEqual(expected, actual, "One of the West walls is broken");
        }
        /*
        [TestMethod]
        public void m_MapTest_Corners_TestMap()
        {
            // test of the test method, should return true

            Game aGame = new Game();
            aGame.SetTestMap(3);
            Tile[,] theMap = aGame.GetMap();
            //Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = true;

            actual = aGame.AreCornersBroken(theMap);
                       
            Assert.AreEqual(expected, actual, "A corner is not being detected as being faulty");
        }
         * */
        [TestMethod]
        public void m_MapTest_Corners_AllMaps()
        {
            Game aGame = new Game();
            aGame.SetMap(1);
            Tile[,] theMap;
            Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = false;
            actual = false;

            // return true if one corner is broken in one of the maps

            for (int i = 0; i < allTheMaps.Length; i++)
            {
                if (allTheMaps[i] != null)
                {
                    theMap = allTheMaps[i];
                    if (aGame.AreCornersBroken(theMap) == true)
                    {
                        actual = true;
                    }
                }
            }
            
            Assert.AreEqual(expected, actual, "One of the corners is broken in the Map library");
        }
        /*
        [TestMethod]
        public void m_MapTest_InnerTiles_TestMap()
        {
            // test of the test method, should return true

            Game aGame = new Game();
            aGame.SetTestMap(3);
            Tile[,] theMap = aGame.GetMap();
            //Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = true;

            actual = aGame.AreInnerTilesBroken(theMap);

            Assert.AreEqual(expected, actual, "An inner tile is not being detected as being faulty");
        }*/
        [TestMethod]
        public void m_MapTest_InnerTiles_AllMaps()
        {
            Game aGame = new Game();
            aGame.SetMap(1);
            Tile[,] theMap;
            Tile[][,] allTheMaps = aGame.GetFiler().GetAllMyMaps();
            bool expected, actual;
            expected = false;
            actual = false;

            // return true if one corner is broken in one of the maps

            for (int i = 0; i < allTheMaps.Length; i++)
            {
                if (allTheMaps[i] != null)
                {
                    theMap = allTheMaps[i];
                    if (aGame.AreInnerTilesBroken(theMap) == true)
                    {
                        actual = true;
                    }
                }
            }

            Assert.AreEqual(expected, actual, "One of the corners is broken in the Map library");
        }

    }
}
