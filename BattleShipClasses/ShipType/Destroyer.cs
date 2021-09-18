using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipClasses.ShipType
{
    public class Destroyer : IShip
    {
        public string Type { get; set; }
        public int Length { get; set; }
        public int Hits { get; set; }
        public SpaceOccupation SpaceOccupation { get; set; }
        public bool IsSunk
        {
            get
            {
                return Hits >= Length;
            }
        }
        public Destroyer()
        {
            Type = "Destroyer";
            Length = 2;
            Hits = 2;
            SpaceOccupation = SpaceOccupation.Destroyer;
        }
    }
}
