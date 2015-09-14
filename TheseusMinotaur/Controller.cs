using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheseusMinotaur
{
    class Controller
    {
        IView view;
        Game model;

        public Controller(IView theView, Game theModel)
        {
            view = theView;
            model = theModel;
        }

        public void GameOver()
        {
            view.Display("Press 'R' to restart, \npress 'N' to go to the next level, \npress 'L' to select a level, \npress 'X' to quit");
            ConsoleKeyInfo theKey = Console.ReadKey();

            if (theKey.Key == ConsoleKey.R)
            {
                model.Restart();
            }
            if (theKey.Key == ConsoleKey.N)
            {
                model.NextMap();
            }
            if (theKey.Key == ConsoleKey.L)
            {
                Init();
            }
            if (theKey.Key == ConsoleKey.X)
            {
                System.Environment.Exit(-1);
            }
        }


        public void Init()
        {
            view.Start();
            model.SetMap(view.SetLevel("Choose a map"));
            /*//model.TestOuterWalls(model.GetMap());
            //model.WestWallBroken(model.GetMap());
            // model.EastWallBroken(model.GetMap());
            // model.SouthWallBroken(model.GetMap());
            //model.NorthWallBroken(model.GetMap());*/
            //model.TestEastWalls();
            //model.TestSouthWalls();
            //model.TestCorners(model.GetMap());
            //model.TestAllInnerTiles();
            while (!model.Run())
            {
                GameOver();
            }
            Console.ReadKey();
        }
    }
}
