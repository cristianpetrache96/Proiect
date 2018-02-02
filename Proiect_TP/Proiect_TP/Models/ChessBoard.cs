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
        public  Hashtable _cells;

        public ChessBoard()
        {
            _cells = new Hashtable();
            _whiteSide = new Side(Side.SideType.White);
            _blackSide = new Side(Side.SideType.Black);
            InitTable2();

        }

        //public void InitTable()
        //{
        //    _cells.Clear();


        //    string key;

        //    for(char c ='a'; c<='h';c++)
        //    {
        //        for(int j=1;j<=8;j++)
        //        {
        //            key = c +""+j;
        //            _cells.Add(key, new Cell());
        //        }
        //    }


        //    _cells["a1"] = new Cell(new Piece(_whiteSide,Piece.PieceType.Rook));
        //    _cells["h1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Rook));
        //    _cells["b1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Knight));
        //    _cells["g1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Knight));
        //    _cells["c1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Bishop));
        //    _cells["f1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Bishop));
        //    _cells["d1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Queen));
        //    _cells["e1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.King));
        //    _cells["a2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
        //    _cells["b2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
        //    _cells["c2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
        //    _cells["d2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
        //    _cells["e2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
        //    _cells["f2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
        //    _cells["g2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));
        //    _cells["h2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn));

        //    _cells["a8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Rook));
        //    _cells["h8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Rook));
        //    _cells["b8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Knight));
        //    _cells["g8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Knight));
        //    _cells["c8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Bishop));
        //    _cells["f8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Bishop));
        //    _cells["d8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Queen));
        //    _cells["e8"] = new Cell(new Piece(_blackSide, Piece.PieceType.King));
        //    _cells["a7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
        //    _cells["b7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
        //    _cells["c7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
        //    _cells["d7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
        //    _cells["e7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
        //    _cells["f7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
        //    _cells["g7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
        //    _cells["h7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn));
        //}

        public void InitTable2()
        {
            _cells.Clear();

            for (int i = 1; i <= 8; i++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    
                    _cells.Add(CellKeyFromRowAndCol(i,j), new Cell(i,j));
                }
            }

            _cells["a1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Rook),1,1);
            _cells["h1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Rook),8,1);
            _cells["b1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Knight),2,1);
            _cells["g1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Knight),7,1);
            _cells["c1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Bishop),3,1);
            _cells["f1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Bishop), 6, 1);
            _cells["d1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Queen), 4, 1);
            _cells["e1"] = new Cell(new Piece(_whiteSide, Piece.PieceType.King), 5, 1);
            _cells["a2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn),1,2);
            _cells["b2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn),2,2);
            _cells["c2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn),3,2);
            _cells["d2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn),4,2);
            _cells["e2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn),5,2);
            _cells["f2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn),6,2);
            _cells["g2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn),7,2);
            _cells["h2"] = new Cell(new Piece(_whiteSide, Piece.PieceType.Pawn),8,2);

            _cells["a8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Rook),1,8);
            _cells["h8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Rook),8,8);
            _cells["b8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Knight),2,8);
            _cells["g8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Knight),7,8);
            _cells["c8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Bishop),3,8);
            _cells["f8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Bishop),6,8);
            _cells["d8"] = new Cell(new Piece(_blackSide, Piece.PieceType.Queen),4,8);
            _cells["e8"] = new Cell(new Piece(_blackSide, Piece.PieceType.King),5,8);
            _cells["a7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn),1,7);
            _cells["b7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn),2,7);
            _cells["c7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn),3,7);
            _cells["d7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn),4,7);
            _cells["e7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn),5,7);
            _cells["f7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn),6,7);
            _cells["g7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn),7,7);
            _cells["h7"] = new Cell(new Piece(_blackSide, Piece.PieceType.Pawn),8,7);
        }

        public void AddCell(string key,Cell newCell)
        {
            _cells.Add(key, newCell);

        }

        public void UpdateCell(string key,Cell newCell)
        {
            _cells[key] = newCell;
        }

        public string GetKey(Cell cell)
        {
            if (cell.Equals(_cells["a2"]))
                Console.WriteLine("asfas");
            return _cells.Keys.OfType<String>().FirstOrDefault(s => _cells[s].Equals(cell));
        }

        public Cell GetCell(string key)
        {
            return (Cell)_cells[key];
        }

        public string CellKeyFromRowAndCol(int row, int col)
        {
            string key;

            key = Convert.ToString(Convert.ToChar(col + 96));
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

        public List<string> GetCellForASide(Side.SideType side)
        {
            List<string> cells = new List<string>();

            for (int row = 1; row <= 8; row++)
                for (int col = 1; col <= 8; col++)
                {
                    Cell cell = GetCell(row, col);
                    if (cell != null && !cell.IsEmpty() && cell.Piece.Side.SideTip==side)
                    {
                        cells.Add(GetKey(cell));
                    }
                }

            return cells;
        }

        public Cell GetTopCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);
            
            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row - 1, col)); 
        }

        public Cell GetBottomCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row +1, col));
        }

        public Cell GetLeftBottomCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row + 1, col-1));
        }

        public Cell GetRightBottomCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row + 1, col + 1));
        }

        public Cell GetLeftTopCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row - 1, col - 1));
        }

        public Cell GetRightTopCell(Cell sourceCell)
        {
            string key = GetKey(sourceCell);

            List<int> rowAndCol = RowAndColFromCellKey(key);
            int row = rowAndCol[0];
            int col = rowAndCol[1];

            return GetCell(CellKeyFromRowAndCol(row - 1, col + 1));
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

        public Hashtable Cells
        {
            get
            {
                return _cells;
            }
            set
            {
                _cells = value;
            }
        }

        public void ClearTable()
        {

            _cells.Clear();
 
        }

        public Hashtable RemoveKeys()
        {
            string key;

            for (char c = 'a'; c <= 'h'; c++)
            {
                for (int j = 1; j <= 8; j++)
                {
                    key = c + "" + j;
                    _cells.Remove(key);
                }
            }

            return _cells;
        }

        public ChessTable GetTable()
        {
            ChessTable table = new ChessTable();

            table.A1 = CellString("a1");
            table.A2 = CellString("a2");
            table.A3 = CellString("a3");
            table.A4 = CellString("a4");
            table.A5 = CellString("a5");
            table.A6 = CellString("a6");
            table.A7 = CellString("a7");
            table.A8 = CellString("a8");

            table.B1 = CellString("b1");
            table.B2 = CellString("b2");
            table.B3 = CellString("b3");
            table.B4 = CellString("b4");
            table.B5 = CellString("b5");
            table.B6 = CellString("b6");
            table.B7 = CellString("b7");
            table.B8 = CellString("b8");

            table.C1 = CellString("c1");
            table.C2 = CellString("c2");
            table.C3 = CellString("c3");
            table.C4 = CellString("c4");
            table.C5 = CellString("c5");
            table.C6 = CellString("c6");
            table.C7 = CellString("c7");
            table.C8 = CellString("c8");

            table.D1 = CellString("d1");
            table.D2 = CellString("d2");
            table.D3 = CellString("d3");
            table.D4 = CellString("d4");
            table.D5 = CellString("d5");
            table.D6 = CellString("d6");
            table.D7 = CellString("d7");
            table.D8 = CellString("d8");

            table.E1 = CellString("e1");
            table.E2 = CellString("e2");
            table.E3 = CellString("e3");
            table.E4 = CellString("e4");
            table.E5 = CellString("e5");
            table.E6 = CellString("e6");
            table.E7 = CellString("e7");
            table.E8 = CellString("e8");

            table.F1 = CellString("f1");
            table.F2 = CellString("f2");
            table.F3 = CellString("f3");
            table.F4 = CellString("f4");
            table.F5 = CellString("f5");
            table.F6 = CellString("f6");
            table.F7 = CellString("f7");
            table.F8 = CellString("f8");

            table.G1 = CellString("g1");
            table.G2 = CellString("g2");
            table.G3 = CellString("g3");
            table.G4 = CellString("g4");
            table.G5 = CellString("g5");
            table.G6 = CellString("g6");
            table.G7 = CellString("g7");
            table.G8 = CellString("g8");

            table.H1 = CellString("h1");
            table.H2 = CellString("h2");
            table.H3 = CellString("h3");
            table.H4 = CellString("h4");
            table.H5 = CellString("h5");
            table.H6 = CellString("h6");
            table.H7 = CellString("h7");
            table.H8 = CellString("h8");

            return table;
        }

        public string CellString(string key)
        {
            Cell cell = (Cell)_cells[key];
            if (cell.Piece.Side !=null && cell.Piece.Side.SideTip == Side.SideType.Black)
            {
                if (cell.Piece.Type == Piece.PieceType.Rook)
                {
                    return "blackRook";
                }
                else if (cell.Piece.Type == Piece.PieceType.King)
                {
                    return "blackKing";
                }
                else if (cell.Piece.Type == Piece.PieceType.Queen)
                {
                    return "blackQueen";
                }
                else if (cell.Piece.Type == Piece.PieceType.Knight)
                {
                    return "blackKnight";
                }
                else if (cell.Piece.Type == Piece.PieceType.Empty)
                {
                    return "";
                }
                else if (cell.Piece.Type == Piece.PieceType.Pawn)
                {
                    return "blackPawn";
                }
                else return "";

            }

            else if (cell.Piece.Side != null && cell.Piece.Side.SideTip == Side.SideType.White)
            {
                if (cell.Piece.Type == Piece.PieceType.Rook)
                {
                    return "whiteRook";
                }
                else if (cell.Piece.Type == Piece.PieceType.King)
                {
                    return "whiteKing";
                }
                else if (cell.Piece.Type == Piece.PieceType.Queen)
                {
                    return "whiteQueen";
                }
                else if (cell.Piece.Type == Piece.PieceType.Knight)
                {
                    return "whiteKnight";
                }
                else if (cell.Piece.Type == Piece.PieceType.Empty)
                {
                    return "";
                }
                else if (cell.Piece.Type == Piece.PieceType.Pawn)
                {
                    return "whitePawn";
                }
                else return "";

            }
            return "";




        }
    }

     
}