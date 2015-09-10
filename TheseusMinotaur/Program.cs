using System;
using System.Drawing;

namespace TheseusMinotaur
{
    class Program
    {
        static void Main(string[] args)
        {

            new Controller(new ConsoleView(), new Game()).Init();


            /*Game aGame = new Game();
            aGame.SetMap(2);
            //Console.WriteLine(aGame.TestMap(aGame.GetMap()));

           // Console.WriteLine(aGame.GetTheseus().IsBlocked(Direction.Left));
            /*aGame.GetTheseus().Move(Direction.Left);
            aGame.GetTheseus().Move(Direction.Left);
            Console.WriteLine(aGame.GetTheseus().Coordinate);

            /*aGame.GetTheseus().Move(Direction.Left);
            Console.WriteLine(aGame.GetTheseus().Coordinate);

            aGame.GetTheseus().Move(Direction.Left);
            Console.WriteLine(aGame.GetTheseus().Coordinate);
           
            
          aGame.Run();*/

            //Console.WriteLine(aGame.SetMap());


            /* aGame.MoveLeft();
             aGame.MinotaursTurn();
             aGame.MoveUp();
             aGame.MinotaursTurn();/*
            // aGame.MinotaursTurn();

             /*
             aGame.MoveLeft();
             aGame.MoveUp();
             aGame.MoveDown();
             aGame.MoveRight();
             aGame.MoveDown();*/

        }
    }
}
