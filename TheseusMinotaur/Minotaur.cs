using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace TheseusMinotaur
{
    class Minotaur : Character
    {
        public Minotaur(int x, int y)
            : base(x, y)
        {

        }

        protected void HuntHorizontal()
        {
            Theseus theseus = myGame.GetTheseus();

            // if Theseus is to the left
            if (Coordinate.X > theseus.Coordinate.X)
            {
                if (!Move(Direction.Left))
                {
                    HuntVertical();
                }
                // Console.WriteLine("mino new pos " + Coordinate);
            }
            if (Coordinate.X < theseus.Coordinate.X)
            {
                if (!Move(Direction.Right))
                {
                    HuntVertical();
                }
                //                Console.WriteLine("mino new pos " + Coordinate);
            }
        }



        protected void HuntVertical()
        {
            Theseus theseus = myGame.GetTheseus();

            if (Coordinate.Y > theseus.Coordinate.Y)
            {
                if (!Move(Direction.Up))
                {
                    Console.WriteLine("blocked");
                }
                //  Console.WriteLine("mino new pos " + Coordinate);
            }
            if (Coordinate.Y < theseus.Coordinate.Y)
            {
                if (!Move(Direction.Down))
                {
                    Console.WriteLine("blocked");
                }
                //   Console.WriteLine("mino new pos " + Coordinate);

            }



        }

        internal void Hunt()
        {
            Theseus theseus = myGame.GetTheseus();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("M turn " + (i + 1));
                // if minotaur's X value isn't the same as theseus'
                if (Coordinate.X != theseus.Coordinate.X)
                {
                    HuntHorizontal();
                }
                else if (Coordinate.X == theseus.Coordinate.X)
                {
                    HuntVertical();
                }
            }
        }


        internal Boolean HasEaten()
        {
            Theseus theseus = myGame.GetTheseus();
            if (Coordinate == theseus.Coordinate)
            {
                return true;
            }
            return false;
        }

    }
}



