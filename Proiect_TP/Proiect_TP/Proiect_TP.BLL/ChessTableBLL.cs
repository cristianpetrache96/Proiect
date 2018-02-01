using Proiect_TP.Models;
using Proiect_TP.Proiect_TP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Proiect_TP.BLL
{
    public class ChessTableBLL
    {
        ChessTableDAL chessTableDAL = new ChessTableDAL();

        public bool AddTable(ChessBoard cb)
        {
           return  chessTableDAL.addTable(cb);
        }

        public List<ChessTable> GetTables()
        {
            return chessTableDAL.GetTables();
        }

        public Guid TableID()
        {
            return chessTableDAL.TableID();
        }

        public bool UpdateTable(ChessBoard cb)
        {
            return chessTableDAL.UpdateTable(cb);
        }

        public ChessBoard GetChessBoard(ChessTable chessTable)
        {
            return chessTableDAL.GetChessBoard(chessTable);
        }
    }
}