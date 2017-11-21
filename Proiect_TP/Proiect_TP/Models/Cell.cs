using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class Cell
    {
        Piece _piece;
        int _row;
        int _col;


        public Cell()
        {
            _row = 0;
            _col = 0;
        }

        public Cell(int row, int col)
        {
            _row = row;
            _col = col;
        }

        public int Row
        {
            get
            {
                return _row;
            }

            set
            {
                _row = value;
            }
        }

        public int Col
        {
            get
            {
                return _col;
            }

            set
            {
                _col = value;
            }
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

        public string GetKey()
        {
            return "" + this.Row + this.Col;
        }

        public bool IsEmpty()
        {
            return _piece == null || _piece.Type == Piece.PieceType.Empty;
        }
    }
}