using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class PieceMove
    {
        private Cell _startCell;
        private Cell _endCell;
        private Piece _movedPiece;
        private Piece _capturedPiece;
        private bool _causeCheck;

        public PieceMove(Cell start, Cell end)
        {
            _startCell = start;
            _endCell = end;
            _movedPiece = start.Piece;
            _capturedPiece = end.Piece;
        }

        public Cell StartCell
        {
            get
            {
                return _startCell;
            }

            set
            {
                _startCell = value;
            }
        }


        public Cell EndCell
        {
            get
            {
                return _endCell;
            }

            set
            {
                _endCell = value;
            }
        }

        public Piece MovedPiece
        {
            get
            {
                return _movedPiece;
            }

            set
            {
                _movedPiece = value;
            }
        }

        public Piece CapturedPiece
        {
            get
            {
                return _capturedPiece;
            }

            set
            {
                _capturedPiece = value;
            }
        }

        public bool CauseCheck
        {
            get
            {
                return _causeCheck;
            }

            set
            {
                _causeCheck = value;
            }
        }
    }
}