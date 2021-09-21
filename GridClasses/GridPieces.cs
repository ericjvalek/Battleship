using BattleShipClasses;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridClasses
{
    public class GridPieces
    {
        //Create a row or colum in the grid
        public SpaceOccupation SpaceOccupation { get; set; }
        public Coordinates Coordinates { get; set; }
        //Construstor for grid
        public GridPieces(int xCord, int yCord)
        {
            //New grid corridinates
            Coordinates = new Coordinates(xCord, yCord);
            //Set space to Enum Description
            SpaceOccupation = SpaceOccupation.EmptySpace;
        }

        public bool ISOccupied
        {
            get
            {
                //Evaluate occupied space and set the space description
                return SpaceOccupation == SpaceOccupation.Battleship
                || SpaceOccupation == SpaceOccupation.Destroyer
                || SpaceOccupation == SpaceOccupation.Carrier
                || SpaceOccupation == SpaceOccupation.Submarine
                || SpaceOccupation == SpaceOccupation.Cruiser;
            }
        }
        //Check if random space is open
        public bool IsRandomAvailable
        {
            get
            {
                //Check if cooridinates has object in every other space
                return (Coordinates.xCord % 2 == 0 && Coordinates.yCord % 2 == 0)
                    || (Coordinates.xCord % 2 == 1 && Coordinates.yCord % 2 == 1);
            }
        }
    }
    public class Coordinates
    {
        public int xCord { get; set; }
        public int yCord { get; set; }

        public Coordinates(int x, int y)
        {
            xCord = x;
            yCord = y;
        }
    }
}
