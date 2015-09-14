using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Theseus_ClassLibrary;
using System.Drawing;


namespace TheseusUnitTests
{
    [TestClass]
    public class d_MinotaurReactions_Walls
    {
        [TestMethod]
        public void d_MinotaurReaction_Horizonal_blocked_1block()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[0, 0].MyWalls = TheWalls.North | TheWalls.East | TheWalls.West;
            aGame.GetMap()[1, 0].MyWalls = TheWalls.North | TheWalls.West;



            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M | T   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        
        [TestMethod]
        public void d_MinotaurReaction_Horizonal_blocked_2blocks()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[0, 0].MyWalls = TheWalls.North | TheWalls.East | TheWalls.West;
            aGame.GetMap()[1, 0].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M | 1   T   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Horizonal_blocked_3blocks()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(3, 0);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[0, 0].MyWalls = TheWalls.North | TheWalls.East | TheWalls.West;
            aGame.GetMap()[1, 0].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M | 1   E   T |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Vertical_1block()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(0, 1);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[0, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.West;
            aGame.GetMap()[0, 1].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
            .___.   .   .   .
            | T             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Vertical_2blocks()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[0, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.West;
            aGame.GetMap()[0, 1].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
            .___.   .   .   .
            | 1             |
            .   .   .   .   .___.
            | T               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Vertical_3blocks()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(0, 3);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[0, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.West;
            aGame.GetMap()[0, 1].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
            .___.   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | T             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }


        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedRight_1block_upright()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[1, 1].MyWalls = TheWalls.East;
            aGame.GetMap()[2, 1].MyWalls = TheWalls.West;

            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .   .   .   .
            | 1   M |       |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedUp_1block_upright()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[1, 1].MyWalls = TheWalls.North;
            aGame.GetMap()[1, 0].MyWalls = TheWalls.South;

            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .___.   .   .
            | 1   M         |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedUpRight_1block_upright()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[1, 1].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetMap()[1, 0].MyWalls = TheWalls.South;
            aGame.GetMap()[2, 1].MyWalls = TheWalls.West;

            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .___.   .   .
            | 1   M |       |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedLeft_1block_upleft()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(0, 0);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[1, 1].MyWalls = TheWalls.West;
            aGame.GetMap()[0, 1].MyWalls = TheWalls.West | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | T   1   2   3 |
            .   .   .   .   .
            | 1 | M         |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedNorth_1block_upleft()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(0, 0);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[1, 1].MyWalls = TheWalls.North;
            aGame.GetMap()[1, 0].MyWalls = TheWalls.South;
            //aGame.GetMap()[0, 1].MyWalls = TheWalls.West | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | T   1   2   3 |
            .   .___.   .   .
            | 1   M         |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedNorthWest_1block_upleft()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(0, 0);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetMap()[1, 1].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetMap()[1, 0].MyWalls = TheWalls.South;
            aGame.GetMap()[0, 1].MyWalls = TheWalls.West | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | T   1   2   3 |
            .   .___.   .   .
            | 1 | M         |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_1block_downright()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 1].MyWalls = TheWalls.East;
            theMap[2, 1].MyWalls = TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   M |       |
            .   .   .   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_1block_downright()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 1].MyWalls = TheWalls.South;
            theMap[1, 2].MyWalls = TheWalls.North;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   M         |
            .   .___.   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddownright_1block_downright()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 1].MyWalls = TheWalls.South | TheWalls.East;
            theMap[1, 2].MyWalls = TheWalls.North;
            theMap[2, 1].MyWalls = TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   M |       |
            .   .___.   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_1block_downleft()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(0, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 1].MyWalls = TheWalls.West;
            theMap[0, 1].MyWalls = TheWalls.West | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1 | M         |
            .   .   .   .   .___.
            | T               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_1block_downleft()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(0, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 1].MyWalls = TheWalls.South;
            theMap[1, 2].MyWalls = TheWalls.North;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   M         |
            .   .___.   .   .___.
            | T               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleftdown_1block_downleft()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 1].MyWalls = TheWalls.South | TheWalls.West;
            theMap[0, 1].MyWalls = TheWalls.West | TheWalls.East;
            theMap[1, 2].MyWalls = TheWalls.North;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1 | M         |
            .   .___.   .   .___.
            | T               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_2blocks_upright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 2);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 2].MyWalls = TheWalls.West;
            theMap[0, 2].MyWalls = TheWalls.East | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   T   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | M |             X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_2blocks_upright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 2);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            //theMap[1, 2].MyWalls = TheWalls.West;
            theMap[0, 2].MyWalls = TheWalls.North | TheWalls.West;
            theMap[0, 1].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   T   2   3 |
            .   .   .   .   .
            | 1             |
            .___.   .   .   .___.
            | M               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupright_2blocks_upright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 2);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(0, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 2].MyWalls = TheWalls.West;
            theMap[0, 2].MyWalls = TheWalls.North | TheWalls.West | TheWalls.East;
            theMap[0, 1].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   T   2   3 |
            .   .   .   .   .
            | 1             |
            .___.   .   .   .___.
            | M |             X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_2blocks_upright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 2);
            thesStart = new Point(2, 1);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 2].MyWalls = TheWalls.West;
            theMap[0, 2].MyWalls = TheWalls.East | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1       T     |
            .   .   .   .   .___.
            | M |             X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_2blocks_upright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 2);
            thesStart = new Point(2, 1);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            //theMap[1, 2].MyWalls = TheWalls.West;
            theMap[0, 2].MyWalls = TheWalls.North | TheWalls.West;
            theMap[0, 1].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1       T     |
            .___.   .   .   .___.
            | M               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupright_2blocks_upright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 2);
            thesStart = new Point(2, 1);
            expectedPoint = new Point(0, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[1, 2].MyWalls = TheWalls.West;
            theMap[0, 2].MyWalls = TheWalls.North | TheWalls.West | TheWalls.East;
            theMap[0, 1].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1       T     |
            .___.   .   .   .___.
            | M |             X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_2blocks_upleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 2);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 2].MyWalls = TheWalls.West;
            theMap[2, 2].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2         | M   X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_2blocks_upleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 2);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 2].MyWalls = TheWalls.North;
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .___.___.
            | 2           M   X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupleft_2blocks_upleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 2);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(3, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 2].MyWalls = TheWalls.North | TheWalls.West;
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.South;
            theMap[2, 2].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .___.___.
            | 2         | M   X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_2blocks_upleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 2);
            thesStart = new Point(1, 1);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 2].MyWalls = TheWalls.West;
            //theMap[3, 1].MyWalls = TheWalls.East | TheWalls.South;
            theMap[2, 2].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   T         |
            .   .   .   .   .___.
            | 2         | M   X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_2blocks_upleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 2);
            thesStart = new Point(1, 1);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 2].MyWalls = TheWalls.North;
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.South;
            //theMap[2, 2].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   T         |
            .   .   .   .___.___.
            | 2           M   X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupleft_2blocks_upleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 2);
            thesStart = new Point(1, 1);
            expectedPoint = new Point(3, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 2].MyWalls = TheWalls.North | TheWalls.West;
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.South;
            theMap[2, 2].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   T         |
            .   .   .   .___.___.
            | 2         | M   X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_2blocks_downleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 1);
            thesStart = new Point(2, 3);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.West;
            theMap[2, 1].MyWalls = TheWalls.East;
           // theMap[2, 2].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1         | M |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3       T     |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_2blocks_downleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 1);
            thesStart = new Point(2, 3);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.South;
            theMap[3, 2].MyWalls = TheWalls.North;
            // theMap[2, 2].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1           M |
            .   .   .   .___.___.
            | 2               X
            .   .   .   .   .___.
            | 3       T     |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleftdown_2blocks_downleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 1);
            thesStart = new Point(2, 3);
            expectedPoint = new Point(3, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.South | TheWalls.West;
            theMap[3, 2].MyWalls = TheWalls.North;
            theMap[2, 1].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1         | M |
            .   .   .   .___.___.
            | 2               X
            .   .   .   .   .___.
            | 3       T     |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_2blocks_downleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 1);
            thesStart = new Point(1, 2);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.West;
            theMap[2, 1].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1         | M |
            .   .   .   .   .___.
            | 2   T           X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_2blocks_downleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 1);
            thesStart = new Point(1, 2);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.South;
            theMap[3, 2].MyWalls = TheWalls.North;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1           M |
            .   .   .   .___.___.
            | 2   T           X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleftdown_2blocks_downleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 1);
            thesStart = new Point(1, 2);
            expectedPoint = new Point(3, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 1].MyWalls = TheWalls.East | TheWalls.South | TheWalls.West;
            theMap[3, 2].MyWalls = TheWalls.North;
            theMap[2, 1].MyWalls = TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1         | M |
            .   .   .   .___.___.
            | 2   T           X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_2blocks_downright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 1);
            thesStart = new Point(1, 3);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 1].MyWalls = TheWalls.East | TheWalls.West;
            theMap[1, 1].MyWalls = TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | M |           |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3   T         |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_2blocks_downright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 1);
            thesStart = new Point(1, 3);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 1].MyWalls = TheWalls.South | TheWalls.West;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.North;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | M             |
            .___.   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3   T         |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedrightdown_2blocks_downright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 1);
            thesStart = new Point(1, 3);
            expectedPoint = new Point(0, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 1].MyWalls = TheWalls.South | TheWalls.West | TheWalls.East;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.North;
            theMap[1, 1].MyWalls = TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | M |           |
            .___.   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3   T         |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_2blocks_downright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 1);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 1].MyWalls = TheWalls.East | TheWalls.West;
            theMap[1, 1].MyWalls = TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | M |           |
            .   .   .   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_2blocks_downright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 1);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 1].MyWalls = TheWalls.South | TheWalls.West;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.North;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | M             |
            .___.   .   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedrightdown_2blocks_downright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 1);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(0, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 1].MyWalls = TheWalls.South | TheWalls.West | TheWalls.East;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.North;
            theMap[1, 1].MyWalls = TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | M |           |
            .___.   .   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_3blocks_upright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(2, 1);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.East;
            theMap[1, 3].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1       T     |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | M |           |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_3blocks_upright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(2, 1);
            expectedPoint = new Point(2, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.North;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1       T     |
            .   .   .   .   .___.
            | 2               X
            .___.   .   .   .___.
            | M             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupright_3blocks_upright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(2, 1);
            expectedPoint = new Point(0, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.North | TheWalls.East;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            theMap[1, 3].MyWalls = TheWalls.South | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1       T     |
            .   .   .   .   .___.
            | 2               X
            .___.   .   .   .___.
            | M |           |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_3blocks_upright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.East;
            theMap[1, 3].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   T   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | M |           |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_3blocks_upright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.North;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   T   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .___.   .   .   .___.
            | M             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupright_3blocks_upright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(0, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.North | TheWalls.East;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            theMap[1, 3].MyWalls = TheWalls.South | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   T   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .___.   .   .   .___.
            | M |           |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_3blocks_upright_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(3, 2);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.East;
            theMap[1, 3].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2           T   X
            .   .   .   .   .___.
            | M |           |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_3blocks_upright_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(3, 2);
            expectedPoint = new Point(2, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.North;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2           T   X
            .___.   .   .   .___.
            | M             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupright_3blocks_upright_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(3, 2);
            expectedPoint = new Point(0, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.North | TheWalls.East;
            theMap[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            theMap[1, 3].MyWalls = TheWalls.South | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2           T   X
            .___.   .   .   .___.
            | M |           |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_3blocks_upleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(1, 1);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.East;
            //theMap[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            theMap[2, 3].MyWalls = TheWalls.South | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   T         |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3         | M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_3blocks_upleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(1, 1);
            expectedPoint = new Point(1, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.North | TheWalls.East;
            theMap[3, 2].MyWalls = TheWalls.South;
            //theMap[2, 3].MyWalls = TheWalls.South | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   T         |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .___.___.
            | 3           M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupleft_3blocks_upleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(1, 1);
            expectedPoint = new Point(3, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.North | TheWalls.East | TheWalls.West;
            theMap[3, 2].MyWalls = TheWalls.South;
            theMap[2, 3].MyWalls = TheWalls.South | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   T         |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .___.___.
            | 3         | M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_3blocks_upleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.East;
            //theMap[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            theMap[2, 3].MyWalls = TheWalls.South | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3         | M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_3blocks_upleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.North | TheWalls.East;
            theMap[3, 2].MyWalls = TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .___.___.
            | 3           M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupleft_3blocks_upleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(3, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.North | TheWalls.East | TheWalls.West;
            theMap[3, 2].MyWalls = TheWalls.South;
            theMap[2, 3].MyWalls = TheWalls.South | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .___.___.
            | 3         | M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_3blocks_upleft_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.West | TheWalls.East;
            //theMap[0, 2].MyWalls = TheWalls.West | TheWalls.South;
            theMap[2, 3].MyWalls = TheWalls.South | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | T               X
            .   .   .   .   .___.
            | 3         | M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedup_3blocks_upleft_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(1, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.North | TheWalls.East;
            theMap[3, 2].MyWalls = TheWalls.South;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | T               X
            .   .   .   .___.___.
            | 3           M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedupleft_3blocks_upleft_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(3, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 3].MyWalls = TheWalls.South | TheWalls.North | TheWalls.East | TheWalls.West;
            theMap[3, 2].MyWalls = TheWalls.South;
            theMap[2, 3].MyWalls = TheWalls.South | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | T               X
            .   .   .   .___.___.
            | 3         | M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        /*** TO DO : THE OTHER DIAGONAL TESTS ***/

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_3blocks_downright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.East | TheWalls.West;
            theMap[1, 0].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M | 1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_3blocks_downright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(2, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.West;
            theMap[0, 1].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
            .___.   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddownright_3blocks_downright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.West | TheWalls.East;
            theMap[0, 1].MyWalls = TheWalls.North | TheWalls.West;
            theMap[1, 0].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M | 1   2   3 |
            .___.   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }


        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_3blocks_downright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(3, 1);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.East | TheWalls.West;
            theMap[1, 0].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M | 1   2   3 |
            .   .   .   .   .
            | 1           T |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }


        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_3blocks_downright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(3, 1);
            expectedPoint = new Point(2, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.West;
            theMap[0, 1].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
            .___.   .   .   .
            | 1           T |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddownright_3blocks_downright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(3, 1);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.West | TheWalls.East;
            theMap[0, 1].MyWalls = TheWalls.North | TheWalls.West;
            theMap[1, 0].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M | 1   2   3 |
            .___.   .   .   .
            | 1           T |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedright_3blocks_downright_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(1, 3);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.East | TheWalls.West;
            theMap[1, 0].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M | 1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3   T         |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_3blocks_downright_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(1, 3);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.West;
            theMap[0, 1].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
            .___.   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3   T         |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddownright_3blocks_downright_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(1, 3);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[0, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.West | TheWalls.East;
            theMap[0, 1].MyWalls = TheWalls.North | TheWalls.West;
            theMap[1, 0].MyWalls = TheWalls.North | TheWalls.West;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M | 1   2   3 |
            .___.   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3   T         |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }


        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_3blocks_downleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(1, 2);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.West | TheWalls.East;
            theMap[2, 0].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2 | M |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2   T           X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_3blocks_downleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(1, 2);
            expectedPoint = new Point(1, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.East;
            theMap[3, 1].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   M |
            .   .   .   .___.
            | 1             |
            .   .   .   .   .___.
            | 2   T           X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleftdown_3blocks_downleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(1, 2);
            expectedPoint = new Point(3, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.East | TheWalls.West;
            theMap[3, 1].MyWalls = TheWalls.North | TheWalls.East;
            theMap[2, 0].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2 | M |
            .   .   .   .___.
            | 1             |
            .   .   .   .   .___.
            | 2   T           X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_3blocks_downleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(0, 1);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.West | TheWalls.East;
            theMap[2, 0].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2 | M |
            .   .   .   .   .
            | T             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_3blocks_downleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(0, 1);
            expectedPoint = new Point(1, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.East;
            theMap[3, 1].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   M |
            .   .   .   .___.
            | T             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleftdown_3blocks_downleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(0, 1);
            expectedPoint = new Point(3, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.East | TheWalls.West;
            theMap[3, 1].MyWalls = TheWalls.North | TheWalls.East;
            theMap[2, 0].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2 | M |
            .   .   .   .___.
            | T             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockedleft_3blocks_downleft_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(2, 3);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.West | TheWalls.East;
            theMap[2, 0].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2 | M |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3       T     |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddown_3blocks_downleft_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(2, 3);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.East;
            theMap[3, 1].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   M |
            .   .   .   .___.
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3       T     |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void d_MinotaurReaction_Diagonal_blockeddownleft_3blocks_downleft_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(2, 3);
            expectedPoint = new Point(3, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            Tile[,] theMap = aGame.GetMap();
            theMap[3, 0].MyWalls = TheWalls.North | TheWalls.South | TheWalls.East | TheWalls.West;
            theMap[3, 1].MyWalls = TheWalls.North | TheWalls.East;
            theMap[2, 0].MyWalls = TheWalls.North | TheWalls.East;
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2 | M |
            .   .   .   .___.
            | 1             |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3       T     |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
    }
}
