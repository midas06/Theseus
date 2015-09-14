using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Drawing;
using Theseus_ClassLibrary;

namespace TheseusUnitTests
{
    [TestClass]
    public class b_Movement_Walls
    {
        [TestMethod]
        public void b_IsBlockedTest_Up()
        {
            Point theseusPoint;
            Boolean expected, actual;
            expected = true;
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            theseusPoint = new Point(1, 0);

            aGame.SetTestMap(1);
            aGame.GetTheseus().Coordinate = theseusPoint;

            /*
            .___.___.___.
            | 0   T   2 |
            .   .   .   .
            | 1         |
            .   .   .   .
            | 2         |
            .___.___.___.  */


            actual = aGame.GetTheseus().IsBlocked(Direction.Up);

            Assert.AreEqual(expected, actual, "Theseus was not on the expected Tile");
        }
        [TestMethod]
        public void b_IsBlockedTest_Down()
        {
            Point theseusPoint;
            Boolean expected, actual;
            expected = true;
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            theseusPoint = new Point(1, 2);

            aGame.SetTestMap(1);
            aGame.GetTheseus().Coordinate = theseusPoint;

            /*
            .___.___.___.
            | 0   1   2 |
            .   .   .   .
            | 1         |
            .   .   .   .
            | 2   T     |
            .___.___.___.  */

            actual = aGame.GetTheseus().IsBlocked(Direction.Down);

            Assert.AreEqual(expected, actual, "Theseus was not on the expected Tile");
        }
        [TestMethod]
        public void b_IsBlockedTest_Left()
        {
            Point theseusPoint;
            Boolean expected, actual;
            expected = true;
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            theseusPoint = new Point(0, 1);

            aGame.SetTestMap(1);
            aGame.GetTheseus().Coordinate = theseusPoint;

            /*
            .___.___.___.
            | 0   1   2 |
            .   .   .   .
            | T         |
            .   .   .   .
            | 2         |
            .___.___.___.  */


            actual = aGame.GetTheseus().IsBlocked(Direction.Left);

            Assert.AreEqual(expected, actual, "Theseus was not on the expected Tile");
        }
        [TestMethod]
        public void b_IsBlockedTest_Right()
        {
            Point theseusPoint;
            Boolean expected, actual;
            expected = true;
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            theseusPoint = new Point(2, 1);

            aGame.SetTestMap(1);
            aGame.GetTheseus().Coordinate = theseusPoint;

            /*
            .___.___.___.
            | 0   1   2 |
            .   .   .   .
            | 1       T |
            .   .   .   .
            | 2         |
            .___.___.___.  */



            actual = aGame.GetTheseus().IsBlocked(Direction.Right);

            Assert.AreEqual(expected, actual, "Theseus was not on the expected Tile");
        }
        [TestMethod]
        public void b_BlockedMovementTest_Up()
        {
            Point expectedPoint, actualPoint, theseusPoint;
            expectedPoint = new Point(1, 0);
            Game aGame = new Game();
            theseusPoint = new Point(1, 0);

            aGame.SetTestMap(1);
            aGame.GetTheseus().Coordinate = theseusPoint;

            /*
            .___.___.___.
            | 0   T   2 |
            .   .   .   .
            | 1         |
            .   .   .   .
            | 2         |
            .___.___.___.  */



            aGame.GetTheseus().Move(Direction.Up);
            actualPoint = aGame.GetTheseusPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Theseus was not on the expected Tile");
        }
        [TestMethod]
        public void b_BlockedMovementTest_Down()
        {
            Point expectedPoint, actualPoint, theseusPoint;
            expectedPoint = new Point(1, 2);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            theseusPoint = new Point(1, 2);

            aGame.SetTestMap(1);
            aGame.GetTheseus().Coordinate = theseusPoint;

            /*
            .___.___.___.
            | 0   1   2 |
            .   .   .   .
            | 1         |
            .   .   .   .
            | 2   T     |
            .___.___.___.  */



            aGame.GetTheseus().Move(Direction.Down);
            actualPoint = aGame.GetTheseusPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Theseus was not on the expected Tile");
        }
        [TestMethod]
        public void b_BlockedMovementTest_Left()
        {
            Point expectedPoint, actualPoint, theseusPoint;
            expectedPoint = new Point(0, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            theseusPoint = new Point(0, 1);

            aGame.SetTestMap(1);
            aGame.GetTheseus().Coordinate = theseusPoint;

            /*
            .___.___.___.
            | 0   1   2 |
            .   .   .   .
            | T         |
            .   .   .   .
            | 2         |
            .___.___.___.  */



            aGame.GetTheseus().Move(Direction.Left);
            actualPoint = aGame.GetTheseusPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Theseus was not on the expected Tile");
        }
        [TestMethod]
        public void b_BlockedMovementTest_Right()
        {
            Point expectedPoint, actualPoint, theseusPoint;
            expectedPoint = new Point(2, 1);
            Game aGame = new Game();
            Theseus theseus = aGame.GetTheseus();
            theseusPoint = new Point(2, 1);

            aGame.SetTestMap(1);
            aGame.GetTheseus().Coordinate = theseusPoint;

            /*
            .___.___.___.
            | 0   1   2 |
            .   .   .   .
            | 1       T |
            .   .   .   .
            | 2         |
            .___.___.___.  */



            aGame.GetTheseus().Move(Direction.Right);
            actualPoint = aGame.GetTheseusPosition();

            Assert.AreEqual(expectedPoint, actualPoint, "Theseus was not on the expected Tile");
        }
    }
}
