using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIPrototype
{
    class Player
    {
        bool isHuman;
        bool name;
        bool isBlack;
        List<ChessPiece> currentPieces;
        public int currentScore;
        public Player()
        {

        }
        public void PlayerInit()
        {

        }
        public int CalculateScore()
        {
            if (currentPieces.Count <= 0)
                return int.MinValue;

            int score = 0;
            foreach(ChessPiece piece in currentPieces)
            {

                switch (piece.Key)
                {
                    case "Pawn":
                        score++;
                        break;
                    case "Rook":
                        score += 10;
                        break;
                    case "Knight":
                        score += 5;
                        break;
                    case "Bishop":
                        score += 8;
                        break;
                    case "Queen":
                        score += 12;
                        break;
                    case "King":
                        score += 3;
                        break;
                    default:
                        break;
                }
            }
            return score;
        }
    }
}
