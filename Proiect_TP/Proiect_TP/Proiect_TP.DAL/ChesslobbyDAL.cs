using Proiect_TP.DBContext;
using Proiect_TP.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proiect_TP.Proiect_TP.DAL
{
    public class ChessLobbyDAL
    {

        private static ContextLobby _context = new ContextLobby();

        internal void finishLobby()
        {
            _context = new ContextLobby();
            ChessLobby chessLobby = new ChessLobby();
            chessLobby = _context.ChessLobby.ToList().ElementAt(0);
            ChessLobby newChessLobby = new ChessLobby();
            newChessLobby.Id = chessLobby.Id;
            _context.ChessLobby.Remove(chessLobby);
            _context.SaveChanges();
            _context.ChessLobby.Add(newChessLobby);
            _context.SaveChanges();

        }
        internal bool isEmpty()
        {
            _context = new ContextLobby();
            ChessLobby chessLobby = new ChessLobby();
            chessLobby = _context.ChessLobby.ToList().ElementAt(0);
            if (chessLobby != null)
            {
                if (chessLobby.user1GUID == new Guid() || chessLobby.user2GUID == new Guid())
                    return true;
            }
            else
            {
                return false;
            }

            return false;
        }
        internal bool addUser(User user)
        {
            try
            {
                _context = new ContextLobby();
                if (isEmpty() == true)
                { 
                    ChessLobby cl = new ChessLobby();
                    cl = _context.ChessLobby.ToList()[0];
                    if (cl.user1GUID == new Guid())
                    {
                        
                        ChessLobby newLobby = new ChessLobby();
                        newLobby.Id = cl.Id;
                        _context.ChessLobby.Remove(cl);
                        _context.SaveChanges();

                        newLobby.user1GUID = user.Id;
                        _context.ChessLobby.Add(newLobby);
                        _context.SaveChanges();
                    
                    }
                    else
                    {
                        ChessLobby newLobby = new ChessLobby();
                        newLobby.Id = cl.Id;
                        newLobby.user1GUID = cl.user1GUID;
                        newLobby.user2GUID = user.Id;
                        _context.ChessLobby.Remove(cl);
                        _context.SaveChanges();
                        _context.ChessLobby.Add(newLobby);
                        _context.SaveChanges();

                    }
                    return true;
                }
            }catch(Exception ex)
            {
                return false;
            }
            return false;
        }
    }
}