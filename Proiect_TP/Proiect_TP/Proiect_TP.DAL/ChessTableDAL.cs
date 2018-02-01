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
                ChessTable ct = new ChessTable();
                ct.Id = Guid.NewGuid();
                ct.A1 = "blackB";
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

        public ChessBoard GetChessBoard()
        {
            ChessBoard chessBoard = new ChessBoard();

            return chessBoard;
        }
    }
}