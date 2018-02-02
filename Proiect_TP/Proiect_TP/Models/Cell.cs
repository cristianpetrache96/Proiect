using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class Cell
    {
        Piece _piece;
        public int row, col;

        public Cell(int row, int col)
        {
            this.row = row;
            this.col = col;
            _piece = new Piece();
        }

        public Cell()
        {
            _piece = new Piece();
        }

        public Cell(Piece piece,int i,int j)
        {
            row = i;
            col = j;
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

        public bool IsOwnedByOpponent(Cell dest)
        {
            if (IsEmpty())
                return false;
            else return _piece.Side.SideTip != dest.Piece.Side.SideTip;
        }

        public bool IsOwnedBySelf(Cell dest)
        {
            if (IsEmpty())
                return false;
            else return _piece.Side.SideTip == dest.Piece.Side.SideTip;
        }

        public override bool Equals(object obj)
        {
            Cell o = (Cell)obj;
            if (this.Piece.ImagePath == o.Piece.ImagePath && this.row == o.row && this.col == o.col )
            {
                return true;
            }
            else return false;
        }
    }
}