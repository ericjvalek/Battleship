using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipClasses
{
    public interface IShip //interface "ship" to establish properties
    {
        string Type { get; set; }
        int Length { get; set; }
        int Hits { get; set; }
        SpaceOccupation SpaceOccupation { get; set; }
        bool IsSunk { get; }
    }

    public enum SpaceOccupation
    {
        [Description("o")]
        EmptySpace,

        [Description("B")]
        Battleship,

        [Description("A")]
        Carrier,

        [Description("C")]
        Cruiser,

        [Description("D")]
        Destroyer,

        [Description("S")]
        Submarine,

        [Description("X")]
        Hit,

        [Description("M")]
        Miss,

    }
}
