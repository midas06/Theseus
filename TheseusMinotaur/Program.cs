using System;
using System.Drawing;

namespace TheseusMinotaur
{
    class Program
    {
        static void Main(string[] args)
        {
            new Controller(new ConsoleView(), new Game()).Init();
        }
    }
}
