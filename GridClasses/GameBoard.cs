using System;
using System.Collections.Generic;

using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GridClasses
{
    public class GameBoard
    {
        
        public List<GridPieces> GridPieces { get; set; }
        // Create a construtor thats loops to make (x) amount of rows/columns
        public GameBoard()
        {
            GridPieces = new List<GridPieces>();
            for (int rows = 1; rows <= 10; rows++)
            {
                for(int columns = 1; columns <= 10; columns++)
                {
                    GridPieces.Add(new GridPieces(rows, columns));
                }
            }
        }
    }
 
}
