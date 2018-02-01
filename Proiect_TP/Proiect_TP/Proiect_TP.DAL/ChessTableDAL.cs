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


            chessBoard.Cells["a1"] = StringToCell(chessTable.A1);
            chessBoard.Cells["a2"] = StringToCell(chessTable.A2);
            chessBoard.Cells["a3"] = StringToCell(chessTable.A3);
            chessBoard.Cells["a4"] = StringToCell(chessTable.A4);
            chessBoard.Cells["a5"] = StringToCell(chessTable.A5);
            chessBoard.Cells["a6"] = StringToCell(chessTable.A6);
            chessBoard.Cells["a7"] = StringToCell(chessTable.A7);
            chessBoard.Cells["a8"] = StringToCell(chessTable.A8);

            chessBoard.Cells["b1"] = StringToCell(chessTable.B1);
            chessBoard.Cells["b2"] = StringToCell(chessTable.B2);
            chessBoard.Cells["b3"] = StringToCell(chessTable.B3);
            chessBoard.Cells["b4"] = StringToCell(chessTable.B4);
            chessBoard.Cells["b5"] = StringToCell(chessTable.B5);
            chessBoard.Cells["b6"] = StringToCell(chessTable.B6);
            chessBoard.Cells["b7"] = StringToCell(chessTable.B7);
            chessBoard.Cells["b8"] = StringToCell(chessTable.B8);

            chessBoard.Cells["c1"] = StringToCell(chessTable.C1);
            chessBoard.Cells["c2"] = StringToCell(chessTable.C2);
            chessBoard.Cells["c3"] = StringToCell(chessTable.C3);
            chessBoard.Cells["c4"] = StringToCell(chessTable.C4);
            chessBoard.Cells["c5"] = StringToCell(chessTable.C5);
            chessBoard.Cells["c6"] = StringToCell(chessTable.C6);
            chessBoard.Cells["c7"] = StringToCell(chessTable.C7);
            chessBoard.Cells["c8"] = StringToCell(chessTable.C8);

            chessBoard.Cells["d1"] = StringToCell(chessTable.D1);
            chessBoard.Cells["d2"] = StringToCell(chessTable.D2);
            chessBoard.Cells["d3"] = StringToCell(chessTable.D3);
            chessBoard.Cells["d4"] = StringToCell(chessTable.D4);
            chessBoard.Cells["d5"] = StringToCell(chessTable.D5);
            chessBoard.Cells["d6"] = StringToCell(chessTable.D6);
            chessBoard.Cells["d7"] = StringToCell(chessTable.D7);
            chessBoard.Cells["d8"] = StringToCell(chessTable.D8);

            chessBoard.Cells["e1"] = StringToCell(chessTable.E1);
            chessBoard.Cells["e2"] = StringToCell(chessTable.E2);
            chessBoard.Cells["e3"] = StringToCell(chessTable.E3);
            chessBoard.Cells["e4"] = StringToCell(chessTable.E4);
            chessBoard.Cells["e5"] = StringToCell(chessTable.E5);
            chessBoard.Cells["e6"] = StringToCell(chessTable.E6);
            chessBoard.Cells["e7"] = StringToCell(chessTable.E7);
            chessBoard.Cells["e8"] = StringToCell(chessTable.E8);

            chessBoard.Cells["f1"] = StringToCell(chessTable.F1);
            chessBoard.Cells["f2"] = StringToCell(chessTable.F2);
            chessBoard.Cells["f3"] = StringToCell(chessTable.F3);
            chessBoard.Cells["f4"] = StringToCell(chessTable.F4);
            chessBoard.Cells["f5"] = StringToCell(chessTable.F5);
            chessBoard.Cells["f6"] = StringToCell(chessTable.F6);
            chessBoard.Cells["f7"] = StringToCell(chessTable.F7);
            chessBoard.Cells["f8"] = StringToCell(chessTable.F8);

            chessBoard.Cells["g1"] = StringToCell(chessTable.G1);
            chessBoard.Cells["g2"] = StringToCell(chessTable.G2);
            chessBoard.Cells["g3"] = StringToCell(chessTable.G3);
            chessBoard.Cells["g4"] = StringToCell(chessTable.G4);
            chessBoard.Cells["g5"] = StringToCell(chessTable.G5);
            chessBoard.Cells["g6"] = StringToCell(chessTable.G6);
            chessBoard.Cells["g7"] = StringToCell(chessTable.G7);
            chessBoard.Cells["g8"] = StringToCell(chessTable.G8);

            chessBoard.Cells["h1"] = StringToCell(chessTable.H1);
            chessBoard.Cells["h2"] = StringToCell(chessTable.H2);
            chessBoard.Cells["h3"] = StringToCell(chessTable.H3);
            chessBoard.Cells["h4"] = StringToCell(chessTable.H4);
            chessBoard.Cells["h5"] = StringToCell(chessTable.H5);
            chessBoard.Cells["h6"] = StringToCell(chessTable.H6);
            chessBoard.Cells["h7"] = StringToCell(chessTable.H7);
            chessBoard.Cells["h8"] = StringToCell(chessTable.H8);



            return chessBoard;
        }

        public Cell StringToCell(string cellString)
        {
            Cell cell = new Cell();

            if (cellString =="whiteRook")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Rook));
            if (cellString == "whiteBishop")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Bishop));
            if (cellString == "whiteKnight")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Knight));
            if (cellString == "whiteKing")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.King));
            if (cellString == "whiteQueen")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Queen));
            if (cellString == "whitePawn")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Pawn));

            if (cellString == "blackRook")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Rook));
            if (cellString == "blackBishop")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Bishop));
            if (cellString == "blackKnight")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Knight));
            if (cellString == "blackKing")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.King));
            if (cellString == "blackQueen")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Queen));
            if (cellString == "blackPawn")
                cell = new Cell(new Piece(new Side(Side.SideType.White), Piece.PieceType.Pawn));

            return cell;


        }



    }
}