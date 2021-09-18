using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridClasses
{
    public static class GridExtention
    {
        public static List<GridPieces> Range(this List<GridPieces> panels,
                                     int xFirstPosition,
                                     int yFirstPosition,
                                     int xLastPosition,
                                     int yLastPosition)
        {
            return panels.Where(piece => piece.Coordinates.xCord >= xFirstPosition
                                     && piece.Coordinates.yCord >= yFirstPosition
                                     && piece.Coordinates.xCord <= xLastPosition
                                     && piece.Coordinates.yCord <= yLastPosition).ToList();
        }
    }
}
