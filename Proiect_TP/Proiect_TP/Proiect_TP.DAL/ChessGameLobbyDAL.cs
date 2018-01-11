using Proiect_TP.DBContext;
using Proiect_TP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proiect_TP.DAL
{
    public class ChessGameLobbyDAL
    {
        private static Context _context = new Context();

        internal bool isEmpty()
        {
            _context = new Context();
            ChessGameLobby gcl = new ChessGameLobby();
            gcl = _context.ChessGameLobby.ElementAt(0);
            if (gcl == null)
            {
                createRoom1();
            }
            if (gcl.user1 == null || gcl.user2 == null)
            {
                return true;
            }
            return false;
        }

        internal bool addUser(User user)
        {
            _context = new Context();
            ChessGameLobby gcl = new ChessGameLobby();
            gcl = _context.ChessGameLobby.ElementAt(0);
            if (isEmpty())
            {
                if (gcl.user1 == null)
                {
                    gcl.user1 = user;
                    _context.Entry<ChessGameLobby>(gcl).State = EntityState.Modified;
                }
                else
                {
                    gcl.user2 = user;
                    _context.Entry<ChessGameLobby>(gcl).State = EntityState.Modified;
                    startGame();
                }
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        internal void startGame()
        {
            ChessBoard chessBoard = new ChessBoard();
            addBoard(chessBoard);
        }
        internal bool addBoard(ChessBoard chessBoard)
        {
            try
            {
                ChessGameLobby gcl = new ChessGameLobby();
                _context = new Context();
                gcl = _context.ChessGameLobby.ElementAt(0);
                //TODO 
                return true;

            }
            catch (Exception e)
            {
                return false;
            }
        }
        internal bool createRoom1()
        {
            try
            { 
            ChessGameLobby gcl = new ChessGameLobby();
            _context = new Context();
            _context.ChessGameLobby.Add(gcl);
            _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
}
    }
}