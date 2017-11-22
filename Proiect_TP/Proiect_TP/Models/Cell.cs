using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class Cell
    {
        Piece _piece;
     


        public Cell()
        {
            _piece = null;
        }

        public Cell(Piece piece)
        {
            _piece = piece;
        }

        public Piece Piece
        {
            get
            {
                return _piece;
            }

            set
            {
                _piece = value;
            }
        }

        public bool IsEmpty()
        {
            return _piece == null || _piece.Type == Piece.PieceType.Empty;
        }
    }
}