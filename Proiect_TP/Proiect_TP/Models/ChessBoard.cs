using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Web;

namespace Proiect_TP.Models
{
    public class ChessBoard
    {
        private Side _whiteSide;
        private Side _blackSide;
        private Hashtable _cells;

        public ChessBoard()
        {
            _cells = new Hashtable();
            _whiteSide = new Side(Side.SideType.White);
            _blackSide = new Side(Side.SideType.Black);
            InitTable();

        }

        public void InitTable()
        {
            _cells.Clear();


            string key;

            for(char c ='a'; c<='g';c++)
            {
                for(int j=1;j<=8;j++)
                {
                    key = c +""+j;
                    _cells.Add(key, new Cell());
                }
            }

            _cells["a1"] = new Cell(new Piece(_whiteSide,Piece.PieceType.Rook));
            _cells["h1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Rook));
            _cells["b1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Knight));
            _cells["g1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Knight));
            _cells["c1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Bishop));
            _cells["f1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Bishop));
            _cells["d1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Queen));
            _cells["e1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.King));
            _cells["a2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
            _cells["b2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
            _cells["c2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
            _cells["d2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
            _cells["e2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
            _cells["f2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
            _cells["g2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
            _cells["h2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));

            _cells["a8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Rook));
            _cells["h8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Rook));
            _cells["b8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Knight));
            _cells["g8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Knight));
            _cells["c8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Bishop));
            _cells["f8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Bishop));
            _cells["d8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Queen));
            _cells["e8"] = new Cell(new Piece(_blackSide, Piece.PieceType.King));
            _cells["a7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
            _cells["b7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
            _cells["c7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
            _cells["d7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
            _cells["e7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
            _cells["f7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
            _cells["g7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
            _cells["h7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
        }

        public void AddCell(string key,Cell newCell)
        {
            _cells.Add(key, newCell);

        }

        public Cell GetCell(string key)
        {
            return (Cell)_cells[key];
        }


        public void RemoveCell(Cell cell)
        {
            if (_cells.Contains(cell))
            {
                _cells.Remove(cell);
            }
        }

        public void ClearTable()
        {
            _cells.Clear();

 
        }
    }
}