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

        public string GetKey(Cell cell)
        {
            return _cells.Keys.OfType<String>().FirstOrDefault(s => _cells[s] == cell);
        }

        public Cell GetCell(string key)
        {
            return (Cell)_cells[key];
        }

        public string CellKeyFromRowAndCol(int row, int col)
        {
            string key;

            key = Convert.ToString(Convert.ToChar(col + 64));
            key += row.ToString();

            return key;
        }

        public List<int> RowAndColFromCellKey(string key)
        {
            List<int> rowAndCol = new List<int>();

            int col = char.Parse(key.Substring(0, 1).ToUpper()) - 64; 
            int row = int.Parse(key.Substring(1, 1));
            rowAndCol.Add(row);
            rowAndCol.Add(col);

            return rowAndCol;
        }


        public Cell GetCell(int row, int col)
        {
            Cell cell = new Cell();

            
            cell = (Cell)_cells[CellKeyFromRowAndCol(row,col)];


            return cell;
        }

        public Cell GetTopCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);
    
            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row + 1, col)); 
        }

        public Cell GetBottomCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row - 1, col));
        }

        public Cell GetLeftBottomCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row - 1, col-1));
        }

        public Cell GetRightBottomCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row - 1, col + 1));
        }

        public Cell GetLeftTopCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row + 1, col - 1));
        }

        public Cell GetRightTopCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row + 1, col + 1));
        }

        public Cell GetLeftCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row, col-1));
        }

        public Cell GetRightCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row, col + 1));
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