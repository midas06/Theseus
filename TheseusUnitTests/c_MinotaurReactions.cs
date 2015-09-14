using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Theseus_ClassLibrary;
using System.Drawing;


namespace TheseusUnitTests
{
    [TestClass]
    public class c_MinotaurReactions
    {
        [TestMethod]
        public void c_MinotaurReaction_Horizonal_1block()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(1, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   T   2   3 |
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
        public void c_MinotaurReaction_Horizonal_2blocks()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   T   3 |
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
        public void c_MinotaurReaction_Horizonal_3blocks()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(3, 0);
            expectedPoint = new Point(2, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   E   T |
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
        public void c_MinotaurReaction_Vertical_1block()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(0, 1);
            expectedPoint = new Point(0, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
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
        public void c_MinotaurReaction_Vertical_2blocks()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(0, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
            .   .   .   .   .
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
        public void c_MinotaurReaction_Vertical_3blocks()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(0, 3);
            expectedPoint = new Point(0, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | E               X
            .   .   .   .   .___.
            | T             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }


        [TestMethod]
        public void c_MinotaurReaction_Diagonal_1block_upright()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .   .   .   .
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
        public void c_MinotaurReaction_Diagonal_1block_upleft()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(0, 0);
            expectedPoint = new Point(0, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | T   1   2   3 |
            .   .   .   .   .
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
        public void c_MinotaurReaction_Diagonal_1block_downright()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   M         |
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
        public void c_MinotaurReaction_Diagonal_1block_downleft()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(1, 1);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(0, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   M         |
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
        public void c_MinotaurReaction_Diagonal_2blocks_upright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 2);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   T   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | M               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void c_MinotaurReaction_Diagonal_2blocks_upright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 2);
            thesStart = new Point(2, 1);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1       T     |
            .   .   .   .   .___.
            | M               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void c_MinotaurReaction_Diagonal_2blocks_upleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 2);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   T   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2           M   X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }
        [TestMethod]
        public void c_MinotaurReaction_Diagonal_2blocks_upleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 2);
            thesStart = new Point(1, 1);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1   T         |
            .   .   .   .   .___.
            | 2           M   X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void c_MinotaurReaction_Diagonal_2blocks_downleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 1);
            thesStart = new Point(2, 3);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1           M |
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
        public void c_MinotaurReaction_Diagonal_2blocks_downleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 1);
            thesStart = new Point(1, 2);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1           M |
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
        public void c_MinotaurReaction_Diagonal_2blocks_downright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 1);
            thesStart = new Point(1, 3);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | M             |
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
        public void c_MinotaurReaction_Diagonal_2blocks_downright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 1);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | M             |
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
        public void c_MinotaurReaction_Diagonal_3blocks_upright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(2, 1);
            expectedPoint = new Point(2, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
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
            | M             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void c_MinotaurReaction_Diagonal_3blocks_upright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(1, 0);
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
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
            | M             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void c_MinotaurReaction_Diagonal_3blocks_upright_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 3);
            thesStart = new Point(3, 2);
            expectedPoint = new Point(2, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
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
            | M             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void c_MinotaurReaction_Diagonal_3blocks_upleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(1, 1);
            expectedPoint = new Point(1, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
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
            | 3           M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void c_MinotaurReaction_Diagonal_3blocks_upleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(2, 0);
            expectedPoint = new Point(2, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
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
            | 3           M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void c_MinotaurReaction_Diagonal_3blocks_upleft_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 3);
            thesStart = new Point(0, 2);
            expectedPoint = new Point(1, 3);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
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
            | 3           M |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actualPoint = aGame.GetMinotaurPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Minotaur was not on the expected Tile");
        }

        [TestMethod]
        public void c_MinotaurReaction_Diagonal_3blocks_downright_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(2, 2);
            expectedPoint = new Point(2, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
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
        public void c_MinotaurReaction_Diagonal_3blocks_downright_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(3, 1);
            expectedPoint = new Point(2, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
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
        public void c_MinotaurReaction_Diagonal_3blocks_downright_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
            thesStart = new Point(1, 3);
            expectedPoint = new Point(1, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 |
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
        public void c_MinotaurReaction_Diagonal_3blocks_downleft_1()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(1, 2);
            expectedPoint = new Point(1, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   M |
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
        public void c_MinotaurReaction_Diagonal_3blocks_downleft_2()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(0, 1);
            expectedPoint = new Point(1, 0);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   M |
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
        public void c_MinotaurReaction_Diagonal_3blocks_downleft_3()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(3, 0);
            thesStart = new Point(2, 3);
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | 0   1   2   M |
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
        
    }
}
