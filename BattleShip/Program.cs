using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleship
{
    public class Position //Creating class to pinpoint locations for attacks
    {
        public int Row { get; set; }
        public int Column { get; set; }

        public Position(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }

    public class iShip //interface "ship" to establish properties
    {
        public string Type { get; set; }
        public int Length { get; set; }
        public int Hits { get; set; }
        
        public bool IsHit 

        public bool isSunk
        
    }
    //Ship classes
    public class Battleship : iShip  
    {
        public Battleship()
        {
            Type = "Battleship";
            Length = 4;
        }
    }

    public class Carrier : iShip
    {
        public Carrier()
        {
            string Type = "Carrier";
            int Length = 5;
        }
    }

    public class Submarine : iShip
    { public Submarine()
        {
            string Type = "Submarine";
            int Length = 3;
        }
    }

    public class Destroyer : iShip
    {
        public Destroyer()
        {
            string Type = "Destroyer";
            int Length = 2;
        }
    }

    public class Cruiser : iShip
    {
        public Cruiser()
        {
            string Type = "Cruiser";
            int Length = 3;
        }
    }


    

    

}


