using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class ChessGameRulesManager
    {
        ChessBoard _board;

        public ChessGameRulesManager(ChessBoard board)
        {
            _board = board;
        }

        public List<string> GetPawnLegalMoves(Cell source)
        {
            List<string> posibleMoves = new List<string>();

            Cell posibleDestination;

         
                posibleDestination = _board.GetTopCell(source);
                if (posibleDestination != null && posibleDestination.IsEmpty())
                    posibleMoves.Add(_board.GetKey(posibleDestination));

                if (posibleDestination != null && posibleDestination.IsEmpty())
                {
                    posibleDestination = _board.GetTopCell(posibleDestination);

                    if (posibleDestination != null && source.Piece.NumberOfMoves == 0 && posibleDestination.IsEmpty())
                        posibleMoves.Add(_board.GetKey(posibleDestination));
                }

            posibleDestination = _board.GetLeftTopCell(source);
            if (posibleDestination != null && posibleDestination.IsOwnedByOpponent(source))
                posibleMoves.Add(_board.GetKey(posibleDestination));

            posibleDestination = _board.GetRightTopCell(source);
            if (posibleDestination != null && posibleDestination.IsOwnedByOpponent(source))
                posibleMoves.Add(_board.GetKey(posibleDestination));

            return posibleMoves;
        }

        private List<string> GetKnightMoves(Cell source)
        {
            List<string> posibleMoves = new List<string>();
            Cell posibleDestination;

            // First check top two left and right moves for knight
            posibleDestination = _board.GetTopCell(source);
            if (posibleDestination != null)
            {
                posibleDestination = _board.GetLeftTopCell(posibleDestination);
                // target cell is empty or is owned by the enemy piece
                if (posibleDestination != null && !posibleDestination.IsOwnedBySelf(source))
                    posibleMoves.Add(_board.GetKey(posibleDestination));

                posibleDestination = _board.GetTopCell(source);
                posibleDestination = _board.GetRightTopCell(posibleDestination);
                // target cell is empty or is owned by the enemy piece
                if (posibleDestination != null && !posibleDestination.IsOwnedBySelf(source))
                    posibleMoves.Add(_board.GetKey(posibleDestination));
            }
            // Now check 2nd bottom left and right cells
            posibleDestination = _board.GetBottomCell(source);
            if (posibleDestination != null)
            {
                posibleDestination = _board.GetLeftBottomCell(posibleDestination);
                // target cell is empty or is owned by the enemy piece
                if (posibleDestination != null && !posibleDestination.IsOwnedBySelf(source))
                    posibleMoves.Add(_board.GetKey(posibleDestination));

                posibleDestination = _board.GetBottomCell(source);
                posibleDestination = _board.GetRightBottomCell(posibleDestination);
                // target cell is empty or is owned by the enemy piece
                if (posibleDestination != null && !posibleDestination.IsOwnedBySelf(source))
                    posibleMoves.Add(_board.GetKey(posibleDestination));
            }
            // Now check 2nd Left Top and bottom cells
            posibleDestination = _board.GetLeftCell(source);
            if (posibleDestination != null)
            {
                posibleDestination = _board.GetLeftTopCell(posibleDestination);
                // target cell is empty or is owned by the enemy piece
                if (posibleDestination != null && !posibleDestination.IsOwnedBySelf(source))
                    posibleMoves.Add(_board.GetKey(posibleDestination));

                posibleDestination = _board.GetLeftCell(source);
                posibleDestination = _board.GetLeftBottomCell(posibleDestination);
                // target cell is empty or is owned by the enemy piece
                if (posibleDestination != null && !posibleDestination.IsOwnedBySelf(source))
                    posibleMoves.Add(_board.GetKey(posibleDestination));
            }
            // Now check 2nd Right Top and bottom cells
            posibleDestination = _board.GetRightCell(source);
            if (posibleDestination != null)
            {
                posibleDestination = _board.GetRightTopCell(posibleDestination);
                // target cell is empty or is owned by the enemy piece
                if (posibleDestination != null && !posibleDestination.IsOwnedBySelf(source))
                    posibleMoves.Add(_board.GetKey(posibleDestination));

                posibleDestination = _board.GetRightCell(source);
                posibleDestination = _board.GetRightBottomCell(posibleDestination);
                // target cell is empty or is owned by the enemy piece
                if (posibleDestination != null && !posibleDestination.IsOwnedBySelf(source))
                    posibleMoves.Add(_board.GetKey(posibleDestination));
            }

            return posibleMoves;
        }
    }
}