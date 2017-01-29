using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrototype
{
    public struct BoardLocation
    {
        public int x, y;
        public bool isOccupied, isBorder;
        public string occupant;
    }
    class ChessBoard
    {
        public BoardLocation[,] locations;
        public ChessBoard()
        {
            locations = new BoardLocation[8, 8];
            for(int i = 0; i < 8; i++)
            {
                for(int j = 0; j < 8; j++)
                {
                    locations[i, j].x = i;
                    locations[i, j].y = j;
                    locations[i, j].isOccupied = false;
                    if (i == 0 || i == 7 || j == 0 || j == 7)
                        locations[i, j].isBorder = true;
                }
            }
        }
    }
}
