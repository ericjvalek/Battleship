using PlayerClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShip
{
    public class Game
    {
        public Player Player1 { get; set; }
        public Player Player2 { get; set; }

        public Game()
        {
            //Create an instance of each player needed
            Player1 = new Player("Austin");
            Player2 = new Player("Erik");
            //Place all of the battleships on the board
            Player1.PutShipsOnBoard();
            Player2.PutShipsOnBoard();
            //Display the game boards
            Player1.OutputBoards();
            Player2.OutputBoards();
        }
    }
}
