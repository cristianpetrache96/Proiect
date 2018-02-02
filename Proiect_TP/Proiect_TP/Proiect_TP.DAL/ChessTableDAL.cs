using Proiect_TP.DBContext;
using Proiect_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Proiect_TP.DAL
{
    public class ChessTableDAL
    {
        private static ContextTable _context = new ContextTable();

        public bool addTable(ChessBoard cb)
        {
            try
            {
                _context = new ContextTable();
                ChessTable ct = cb.GetTable();
                ct.Id = Guid.NewGuid(); 
                _context.ChessTable.Add(ct);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                return false;
            }
        }

        public List<ChessTable> GetTables()
        {
            try
            {
                _context = new ContextTable();
                
                return _context.ChessTable.ToList();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                return null;
            }
        }

        public Guid TableID()
        {
            try
            {
                _context = new ContextTable();
               Guid id = _context.ChessTable.ToList()[0].Id;
                return id;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                return new Guid();
            }
        }

        public bool UpdateTable(ChessBoard cb)
        {
            try
            {
                ChessTable newTable = cb.GetTable();
                _context = new ContextTable();
                
                ChessTable oldTable = _context.ChessTable.ToList()[0];
                newTable.Id = oldTable.Id;
                _context.ChessTable.Remove(oldTable);
                _context.SaveChanges();
                _context.ChessTable.Add(newTable);
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException);
                return false;
            }
        }

        public ChessBoard GetChessBoard(ChessTable chessTable)
        {
            ChessBoard chessBoard = new ChessBoard();
            chessBoard.ClearTable();

            chessBoard.UpdateCell("a1", StringToCell(chessTable.A1, "a1"));
            chessBoard.UpdateCell("a2", StringToCell(chessTable.A2, "a2"));
            chessBoard.UpdateCell("a3", StringToCell(chessTable.A3, "a3"));
            chessBoard.UpdateCell("a4", StringToCell(chessTable.A4, "a4"));
            chessBoard.UpdateCell("a5", StringToCell(chessTable.A5, "a5"));
            chessBoard.UpdateCell("a6", StringToCell(chessTable.A6, "a6"));
            chessBoard.UpdateCell("a7", StringToCell(chessTable.A7, "a7"));
            chessBoard.UpdateCell("a8", StringToCell(chessTable.A8, "a8"));

            chessBoard.UpdateCell("b1", StringToCell(chessTable.B1, "b1"));
            chessBoard.UpdateCell("b2", StringToCell(chessTable.B2, "b2"));
            chessBoard.UpdateCell("b3", StringToCell(chessTable.B3, "b3"));
            chessBoard.UpdateCell("b4", StringToCell(chessTable.B4, "b4"));
            chessBoard.UpdateCell("b5", StringToCell(chessTable.B5, "b5"));
            chessBoard.UpdateCell("b6", StringToCell(chessTable.B6, "b6"));
            chessBoard.UpdateCell("b7", StringToCell(chessTable.B7, "b7"));
            chessBoard.UpdateCell("b8", StringToCell(chessTable.B8, "b8"));

            chessBoard.UpdateCell("c1", StringToCell(chessTable.C1, "c1"));
            chessBoard.UpdateCell("c2", StringToCell(chessTable.C2, "c2"));
            chessBoard.UpdateCell("c3", StringToCell(chessTable.C3, "c3"));
            chessBoard.UpdateCell("c4", StringToCell(chessTable.C4, "c4"));
            chessBoard.UpdateCell("c5", StringToCell(chessTable.C5, "c5"));
            chessBoard.UpdateCell("c6", StringToCell(chessTable.C6, "c6"));
            chessBoard.UpdateCell("c7", StringToCell(chessTable.C7, "c7"));
            chessBoard.UpdateCell("c8", StringToCell(chessTable.C8, "c8"));

            chessBoard.UpdateCell("d1", StringToCell(chessTable.D1, "d1"));
            chessBoard.UpdateCell("d2", StringToCell(chessTable.D2, "d2"));
            chessBoard.UpdateCell("d3", StringToCell(chessTable.D3, "d3"));
            chessBoard.UpdateCell("d4", StringToCell(chessTable.D4, "d4"));
            chessBoard.UpdateCell("d5", StringToCell(chessTable.D5, "d5"));
            chessBoard.UpdateCell("d6", StringToCell(chessTable.D6, "d6"));
            chessBoard.UpdateCell("d7", StringToCell(chessTable.D7, "d7"));
            chessBoard.UpdateCell("d8", StringToCell(chessTable.D8, "d8"));

            chessBoard.UpdateCell("e1", StringToCell(chessTable.E1, "e1"));
            chessBoard.UpdateCell("e2", StringToCell(chessTable.E2, "e2"));
            chessBoard.UpdateCell("e3", StringToCell(chessTable.E3, "e3"));
            chessBoard.UpdateCell("e4", StringToCell(chessTable.E4, "e4"));
            chessBoard.UpdateCell("e5", StringToCell(chessTable.E5, "e5"));
            chessBoard.UpdateCell("e6", StringToCell(chessTable.E6, "e6"));
            chessBoard.UpdateCell("e7", StringToCell(chessTable.E7, "e7"));
            chessBoard.UpdateCell("e8", StringToCell(chessTable.E8, "e8"));

            chessBoard.UpdateCell("f1", StringToCell(chessTable.F1, "f1"));
            chessBoard.UpdateCell("f2", StringToCell(chessTable.F2, "f2"));
            chessBoard.UpdateCell("f3", StringToCell(chessTable.F3, "f3"));
            chessBoard.UpdateCell("f4", StringToCell(chessTable.F4, "f4"));
            chessBoard.UpdateCell("f5", StringToCell(chessTable.F5, "f5"));
            chessBoard.UpdateCell("f6", StringToCell(chessTable.F6, "f6"));
            chessBoard.UpdateCell("f7", StringToCell(chessTable.F7, "f7"));
            chessBoard.UpdateCell("f8", StringToCell(chessTable.F8, "f8"));

            chessBoard.UpdateCell("g1", StringToCell(chessTable.G1, "g1"));
            chessBoard.UpdateCell("g2", StringToCell(chessTable.G2, "g2"));
            chessBoard.UpdateCell("g3", StringToCell(chessTable.G3, "g3"));
            chessBoard.UpdateCell("g4", StringToCell(chessTable.G4, "g4"));
            chessBoard.UpdateCell("g5", StringToCell(chessTable.G5, "g5"));
            chessBoard.UpdateCell("g6", StringToCell(chessTable.G6, "g6"));
            chessBoard.UpdateCell("g7", StringToCell(chessTable.G7, "g7"));
            chessBoard.UpdateCell("g8", StringToCell(chessTable.G8, "g8"));

            chessBoard.UpdateCell("h1", StringToCell(chessTable.H1, "h1"));
            chessBoard.UpdateCell("h2", StringToCell(chessTable.H2, "h2"));
            chessBoard.UpdateCell("h3", StringToCell(chessTable.H3, "h3"));
            chessBoard.UpdateCell("h4", StringToCell(chessTable.H4, "h4"));
            chessBoard.UpdateCell("h5", StringToCell(chessTable.H5, "h5"));
            chessBoard.UpdateCell("h6", StringToCell(chessTable.H6, "h6"));
            chessBoard.UpdateCell("h7", StringToCell(chessTable.H7, "h7"));
            chessBoard.UpdateCell("h8", StringToCell(chessTable.H8, "h8"));

            return chessBoard;
        }

        public Cell StringToCell(string cellString,string key)
        {
            Cell cell = new Cell();
            ChessBoard board = new ChessBoard();
            List<int> rowAndCol = board.RowAndColFromCellKey(key);
       
            



            if (cellString =="whiteRook")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Rook),rowAndCol[0],rowAndCol[1]);
            if (cellString == "whiteBishop")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Bishop), rowAndCol[0], rowAndCol[1]);
            if (cellString == "whiteKnight")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Knight), rowAndCol[0], rowAndCol[1]);
            if (cellString == "whiteKing")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.King), rowAndCol[0], rowAndCol[1]);
            if (cellString == "whiteQueen")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Queen), rowAndCol[0], rowAndCol[1]);
            if (cellString == "whitePawn")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Pawn), rowAndCol[0], rowAndCol[1]);

            if (cellString == "blackRook")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Rook),rowAndCol[0], rowAndCol[1]);
            if (cellString == "blackBishop")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Bishop), rowAndCol[0], rowAndCol[1]);
            if (cellString == "blackKnight")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Knight), rowAndCol[0], rowAndCol[1]);
            if (cellString == "blackKing")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.King), rowAndCol[0], rowAndCol[1]);
            if (cellString == "blackQueen")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Queen), rowAndCol[0], rowAndCol[1]);
            if (cellString == "blackPawn")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Pawn), rowAndCol[0], rowAndCol[1]);
            if (cellString == "")
                cell = new Cell(rowAndCol[0], rowAndCol[1]);
            return cell;


        }



    }
}