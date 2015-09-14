using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Theseus_ClassLibrary;
using System.Drawing;


namespace TheseusUnitTests
{
    [TestClass]
    public class e_ExitTile
    {
        [TestMethod]
        public void e_ExitTile_FinishedMap()
        {
            Point thesStart;
            bool expected, actual;
            thesStart = new Point(3, 2);
            expected = true;
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;
            
            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2           T   X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */

            aGame.GetTheseus().Move(Direction.Right);
            actual = aGame.GetTheseus().IsFinished();

            Assert.AreEqual(actual, expected, "Theseus did not finish the maze");

        }
        [TestMethod]
        public void e_ExitTile_NotFinished()
        {
            Point thesStart;
            bool expected, actual;
            thesStart = new Point(2, 2);
            expected = false;
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            Minotaur minotaur = aGame.GetMinotaur();

            aGame.SetTestMap(2);
            aGame.GetTheseus().Coordinate = thesStart;

            /*
            .___.___.___.___.
            | 0   1   2   3 |
            .   .   .   .   .
            | 1             |
            .   .   .   .   .___.
            | 2       T       X
            .   .   .   .   .___.
            | 3             |
            .___.___.___.___. */

            aGame.GetTheseus().Move(Direction.Right);
            actual = aGame.GetTheseus().IsFinished();

            Assert.AreEqual(actual, expected, "Theseus finished the maze");



        }
    }
}
