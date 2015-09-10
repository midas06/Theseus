using System;
using System.Drawing;

namespace Theseus_ClassLibrary
{
    class Program
    {
        static void Main(string[] args)
        {
            //new Controller(new ConsoleView(), new Game()).Init();
            Game aGame = new Game();
            aGame.Run();
        }
    }
}
