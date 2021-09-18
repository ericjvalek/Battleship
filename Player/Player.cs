using BattleShipClasses;
using BattleShipClasses.ShipType;
using GridClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PlayerClass
{
    public class Player
    {
        public string Name { get; set; }
        public GameBoard Gameboard { get; set; }
        public FiringBoard FiringBoard { get; set; }
        public List<IShip> Ship { get; set; }
        public bool HasLost
        {
            get
            {
                return Ship.All(ships => ships.IsSunk);
            }
        }
        public Player(string name)
        {
            Name = name;
            Ship = new List<IShip>()
            {
                new Battleship(),
                new Carrier(),
                new Cruiser(),
                new Destroyer(),
                new Submarine()
            };
            Gameboard = new GameBoard();
            FiringBoard = new FiringBoard();
        }
    public void PutShipsOnBoard()
    {
        var randNum = new Random();
        //Create a loop that checks the board for random coordinates
        foreach (IShip ship in Ship)
        {
                //make sure that you check each gridPiece is empty for all ships
                bool shipsLeft = true;
                while (shipsLeft)
                {
                    //Create variables for your Range method to check if spaces are empty
                    int xFirstPosition = randNum.Next(1, 11);
                    int yFirstPosition = randNum.Next(1, 11);
                    int yLastPostion = yFirstPosition;
                    int xLastPosition = xFirstPosition;
                    //Create variable to change the horizontal and verticle orientation
                    int orientationVariable = randNum.Next(1 - 101) % 2;
                    //Create a list to capture gridPositions
                    List<int> gridPosition = new List<int>();
                    //Change the orientation
                    if(orientationVariable == 0)
                    {
                        for(int i = 1; i < ship.Length; i++)
                        {
                            yLastPostion++;
                        }
                    }
                    else
                    {
                        for(int i = 1; i < ship.Length; i++)
                        {
                            xLastPosition++;
                        }
                    }
                 //Make sure the the gridPiece is in the grid 
                 if(xLastPosition > 10 || yLastPostion > 10)
                    {
                        //If it is outside the grid restart the loop with a new random number
                        shipsLeft = true;
                        continue;
                    }
                    //Check to see if the gridPositions you have are empty 
                    var currentPositions = GridExtention.Range(xFirstPosition,
                                                               yFirstPosition,
                                                               xLastPosition,
                                                               yLastPostion);

                }
        }
    }
    }
}
