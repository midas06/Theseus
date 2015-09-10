using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Theseus_ClassLibrary;
using System.Drawing;


namespace TheseusUnitTests
{
    [TestClass]
    public class b_MinotaurReactions
    {
        [TestMethod]
        public void c_MinotaurReaction_Horizonal_a()
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
        public void c_MinotaurReaction_Horizonal_b()
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
            | M   1   E   3 |
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
        public void c_MinotaurReaction_Vertical()
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
        public void c_MinotaurReaction_Diagonal()
        {
            Point expectedPoint, actualPoint, minStart, thesStart;
            minStart = new Point(0, 0);
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
            | M   1   2   3 |
            .   .   .   .   .
            | 1   E         |
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
        public void c_MinotaurReaction_EatsTheseus_1space()
        {
            Point minStart, thesStart;
            bool expected, actual;
            minStart = new Point(0, 0);
            thesStart = new Point(1, 0);
            expected = true;
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
            actual = aGame.GetMinotaur().HasEaten();

            Assert.AreEqual(expected, actual, "Minotaur did not eat Theseus");
        }
        [TestMethod]
        public void c_MinotaurReaction_EatsTheseus_2spaces()
        {
            Point minStart, thesStart;
            bool expected, actual;
            minStart = new Point(0, 0);
            thesStart = new Point(1, 1);
            expected = true;
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            aGame.GetMinotaur().Coordinate = minStart;

            /*
            .___.___.___.___.
            | M   1   2   3 | 4
            .   .   .   .   .
            | 1   T         |
            .   .   .   .   .___.
            | 2               X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */



            aGame.GetMinotaur().Hunt();
            actual = aGame.GetMinotaur().HasEaten();

            Assert.AreEqual(expected, actual, "Minotaur did not eat Theseus");
        }
        [TestMethod]
        public void c_MinotaurReaction_CantEat()
        {
            Point minStart, thesStart;
            bool expected, actual;
            minStart = new Point(0, 0);
            thesStart = new Point(3, 0);
            expected = false;
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
            actual = aGame.GetMinotaur().HasEaten();

            Assert.AreEqual(expected, actual, "Minotaur ate Theseus");
        }
    }
}
