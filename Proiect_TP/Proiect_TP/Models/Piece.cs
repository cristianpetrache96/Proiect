using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public abstract class Piece
    {
        int _moves;
        Side _side;
        PieceType _type;

        public enum PieceType { Empty, King, Queen, Rook, Bishop, Knight, Pawn };


        public PieceType Type
        {
            get
            {
                return _type;
            }
            set
            {
                _type = value;
            }
        }

        public Side Side
        {
            get
            {
                return _side;
            }
            set
            {
                _side = value;
            }
        }



    }

    
}