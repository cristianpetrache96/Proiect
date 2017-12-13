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

        public List<string> GetPawnMoves(Cell source)
        {
            List<string> possibleMoves = new List<string>();

            Cell possibleDestination;

         
                possibleDestination = _board.GetTopCell(source);
                if (possibleDestination != null && possibleDestination.IsEmpty())
                    possibleMoves.Add(_board.GetKey(possibleDestination));

                if (possibleDestination != null && possibleDestination.IsEmpty())
                {
                    possibleDestination = _board.GetTopCell(possibleDestination);

                    if (possibleDestination != null && source.Piece.NumberOfMoves == 0 && possibleDestination.IsEmpty())
                        possibleMoves.Add(_board.GetKey(possibleDestination));
                }

            possibleDestination = _board.GetLeftTopCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));

            possibleDestination = _board.GetRightTopCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));

            return possibleMoves;
        }

        private List<string> GetKnightMoves(Cell source)
        {
            List<string> possibleMoves = new List<string>();
            Cell possibleDestination;

           
            possibleDestination = _board.GetTopCell(source);
            if (possibleDestination != null)
            {
                possibleDestination = _board.GetLeftTopCell(possibleDestination);
               
                if (possibleDestination != null && !possibleDestination.IsOwnedBySelf(source))
                    possibleMoves.Add(_board.GetKey(possibleDestination));

                possibleDestination = _board.GetTopCell(source);
                possibleDestination = _board.GetRightTopCell(possibleDestination);

                if (possibleDestination != null && !possibleDestination.IsOwnedBySelf(source))
                    possibleMoves.Add(_board.GetKey(possibleDestination));
            }
           
            possibleDestination = _board.GetBottomCell(source);
            if (possibleDestination != null)
            {
                possibleDestination = _board.GetLeftBottomCell(possibleDestination);
             
                if (possibleDestination != null && !possibleDestination.IsOwnedBySelf(source))
                    possibleMoves.Add(_board.GetKey(possibleDestination));

                possibleDestination = _board.GetBottomCell(source);
                possibleDestination = _board.GetRightBottomCell(possibleDestination);
               
                if (possibleDestination != null && !possibleDestination.IsOwnedBySelf(source))
                    possibleMoves.Add(_board.GetKey(possibleDestination));
            }
           
            possibleDestination = _board.GetLeftCell(source);
            if (possibleDestination != null)
            {
                possibleDestination = _board.GetLeftTopCell(possibleDestination);
             
                if (possibleDestination != null && !possibleDestination.IsOwnedBySelf(source))
                    possibleMoves.Add(_board.GetKey(possibleDestination));

                possibleDestination = _board.GetLeftCell(source);
                possibleDestination = _board.GetLeftBottomCell(possibleDestination);
               
                if (possibleDestination != null && !possibleDestination.IsOwnedBySelf(source))
                    possibleMoves.Add(_board.GetKey(possibleDestination));
            }
           
            possibleDestination = _board.GetRightCell(source);
            if (possibleDestination != null)
            {
                possibleDestination = _board.GetRightTopCell(possibleDestination);
                
                if (possibleDestination != null && !possibleDestination.IsOwnedBySelf(source))
                    possibleMoves.Add(_board.GetKey(possibleDestination));

                possibleDestination = _board.GetRightCell(source);
                possibleDestination = _board.GetRightBottomCell(possibleDestination);
               
                if (possibleDestination != null && !possibleDestination.IsOwnedBySelf(source))
                    possibleMoves.Add(_board.GetKey(possibleDestination));
            }

            return possibleMoves;
        }

        public List<string> GetRookMoves(Cell source)
        {
            List<string> possibleMoves = new List<string>();
            Cell possibleDestination;

            possibleDestination = _board.GetTopCell(source);
            while(possibleDestination!= null)
            {
                if (possibleDestination.IsEmpty())
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                if (possibleDestination.IsOwnedByOpponent(source))
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                    break;
                }

                if(possibleDestination.IsOwnedBySelf(source))
                {
                    break;
                }

                possibleDestination = _board.GetTopCell(possibleDestination);
            }

            possibleDestination = _board.GetLeftCell(source);
            while(possibleDestination!=null)
            {
                if(possibleDestination.IsEmpty())
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                }

                if (possibleDestination.IsOwnedByOpponent(possibleDestination))
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                    break;
                }

                if(possibleDestination.IsOwnedBySelf(source))
                {
                    break;
                }

                possibleDestination = _board.GetLeftCell(possibleDestination);
            }

            possibleDestination = _board.GetBottomCell(source);
            while(possibleDestination != null)
            {
                if(possibleDestination.IsEmpty())
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                }

                if(possibleDestination.IsOwnedByOpponent(source))
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                    break;
                }

                if (possibleDestination.IsOwnedBySelf(source))
                    break;

                possibleDestination = _board.GetBottomCell(possibleDestination);
            }

            possibleDestination = _board.GetRightCell(source);
            while (possibleDestination != null)
            {
                if (possibleDestination.IsEmpty())
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                }

                if (possibleDestination.IsOwnedByOpponent(source))
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                    break;
                }

                if (possibleDestination.IsOwnedBySelf(source))
                    break;

                possibleDestination = _board.GetRightCell(possibleDestination);
            }
            return possibleMoves;
        }

        public List<string> GetBishopMoves(Cell source)
        {
            List<string> possibleMoves = new List<string>();
            Cell possibleDestination;

            possibleDestination = _board.GetLeftTopCell(source);
            while(possibleDestination != null)
            {
                if(possibleDestination.IsEmpty())
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                }

                if(possibleDestination.IsOwnedByOpponent(source))
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                    break;
                }

                if (possibleDestination.IsOwnedBySelf(source))
                    break;
                possibleDestination = _board.GetLeftTopCell(possibleDestination);
            }

            possibleDestination = _board.GetRightTopCell(source);
            while (possibleDestination != null)
            {
                if (possibleDestination.IsEmpty())
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                }

                if (possibleDestination.IsOwnedByOpponent(source))
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                    break;
                }

                if (possibleDestination.IsOwnedBySelf(source))
                    break;
                possibleDestination = _board.GetRightTopCell(possibleDestination);
            }

            possibleDestination = _board.GetRightBottomCell(source);
            while (possibleDestination != null)
            {
                if (possibleDestination.IsEmpty())
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                }

                if (possibleDestination.IsOwnedByOpponent(source))
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                    break;
                }

                if (possibleDestination.IsOwnedBySelf(source))
                    break;
                possibleDestination = _board.GetRightBottomCell(possibleDestination);
            }

            possibleDestination = _board.GetLeftBottomCell(source);
            while (possibleDestination != null)
            {
                if (possibleDestination.IsEmpty())
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                }

                if (possibleDestination.IsOwnedByOpponent(source))
                {
                    possibleMoves.Add(_board.GetKey(possibleDestination));
                    break;
                }

                if (possibleDestination.IsOwnedBySelf(source))
                    break;
                possibleDestination = _board.GetLeftBottomCell(possibleDestination);
            }
            return possibleMoves;
        }

        public List<string> GetQueenMoves(Cell source)
        {
            List<string> possibleMoves = new List<string>();

            possibleMoves = GetBishopMoves(source).Concat(GetRookMoves(source)).ToList();

            return possibleMoves;
        }
            

        public List<string> GetKingMoves(Cell source)
        {
            List<string> possibleMoves = new List<string>();

            Cell possibleDestination;

            possibleDestination = _board.GetTopCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));

            possibleDestination = _board.GetBottomCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));

            possibleDestination = _board.GetLeftCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));

            possibleDestination = _board.GetRightCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));

            possibleDestination = _board.GetLeftTopCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));

            possibleDestination = _board.GetRightTopCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));

            possibleDestination = _board.GetRightBottomCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));

            possibleDestination = _board.GetLeftBottomCell(source);
            if (possibleDestination != null && possibleDestination.IsOwnedByOpponent(source))
                possibleMoves.Add(_board.GetKey(possibleDestination));




            return possibleMoves;
        }

        public List<string> GetOnlyLegalMoves(Cell source)
        {
            List<string> legalMoves = new List<string>();
            legalMoves = GetPossibleMoves(source);
            foreach  (string dest  in legalMoves)
            {
                if(CauseCheck(new PieceMove(source,_board.GetCell(dest))))
                {
                    legalMoves.Remove(dest);
                }
            }

            return legalMoves;
        }



        public bool CauseCheck(PieceMove move)
        {
            bool check = false;

            Side.SideType side = move.StartCell.Piece.Side.SideTip;
            ExecuteMove(move);
            check = IsUnderCheck(side);
            UndoMove(move);

            return check;
            
        }

        public void ExecuteMove(PieceMove move)
        {
            _board.GetCell(_board.GetKey(move.StartCell)).Piece.NumberOfMoves++;
            _board.GetCell(_board.GetKey(move.EndCell)).Piece = _board.GetCell(_board.GetKey(move.StartCell)).Piece;
            _board.GetCell(_board.GetKey(move.StartCell)).Piece = new Piece(move.StartCell.Piece.Side, Piece.PieceType.Empty);
        }

        public void UndoMove(PieceMove move)
        {
            _board.GetCell(_board.GetKey(move.EndCell)).Piece = move.CapturedPiece;
            _board.GetCell(_board.GetKey(move.StartCell)).Piece = move.MovedPiece;
            _board.GetCell(_board.GetKey(move.StartCell)).Piece.NumberOfMoves--;
        }

        public bool IsUnderCheck(Side.SideType playerSide)
        {
            string kingOwnerCell = null;
            List<string> ownerCells = _board.GetCellForASide(playerSide);
            
            foreach(string cell in ownerCells)
            {
                if(_board.GetCell(cell).Piece.Type == Piece.PieceType.King)
                {
                    kingOwnerCell = cell;
                    break;
                }
            }

            List<string> enemyCells = _board.GetCellForASide(new Side(playerSide).Enemy());
            foreach (string cell in enemyCells)
            {
                List<string> possibleMoves = GetPossibleMoves(_board.GetCell(cell));

                if (possibleMoves.Contains(cell))
                    return true;
            }
            return false;

            
        }

        public List<string> GetPossibleMoves(Cell source)
        {
            List<string> possibleMoves = new List<string>();


            switch(source.Piece.Type)
            {
                case Piece.PieceType.Empty:
                    break;
                case Piece.PieceType.Bishop:
                    possibleMoves = GetBishopMoves(source);
                    break;
                case Piece.PieceType.Pawn:
                    possibleMoves = GetPawnMoves(source);
                    break;
                case Piece.PieceType.Knight:
                    possibleMoves = GetKnightMoves(source);
                    break;
                case Piece.PieceType.Queen:
                    possibleMoves = GetQueenMoves(source);
                    break;
                case Piece.PieceType.Rook:
                    possibleMoves = GetRookMoves(source);
                    break;
                case Piece.PieceType.King:
                    possibleMoves = GetKingMoves(source);
                    break;

            }


            return possibleMoves;
        }
    }
}