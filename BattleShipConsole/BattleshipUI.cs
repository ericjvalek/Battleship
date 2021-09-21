using BattleShipClasses;
using GridClasses;
using PlayerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipConsole
{
    public class BattleshipUI
    {
        public void Run()
        {
            OutputBoards();
        }

        public void OutputBoards()
        {
            Console.WriteLine("Name");
            Console.WriteLine("Own board:                               Firing Board:");
            for (int row = 1; row <= 10; row++)
            {
                for (int myBoard = 1; myBoard <= 10; myBoard++)
                {
                    Console.WriteLine();
                }
            }
        }

        public void MainMenu()
        {

        }

        
    }

    public class Game
    {
         public Player Player1 { get; set; }
         public Player Player2 { get; set; }

        public Game() { }

        public void PlayRound() { }

        public void PlayToEnd() { }
    }

}
     