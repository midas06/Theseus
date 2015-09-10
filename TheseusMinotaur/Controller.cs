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
            view.Display("Press 'R' to restart, press 'L' to change levels");
            ConsoleKeyInfo theKey = Console.ReadKey();

            if (theKey.Key == ConsoleKey.R)
            {
                model.Restart();
            }
            if (theKey.Key == ConsoleKey.L)
            {
                Init();
            }
            if (theKey.Key == ConsoleKey.X)
            {
                view.Stop();
            }


        }


        public void Init()
        {
            view.Start();
            model.SetMap(view.SetLevel("Choose a map"));
            while (!model.Run())
            {
                GameOver();
            }

        }
    }
}
