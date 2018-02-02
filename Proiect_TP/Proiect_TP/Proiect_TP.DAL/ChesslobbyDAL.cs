using Proiect_TP.BLL;
using Proiect_TP.DBContext;
using Proiect_TP.Models;
using Proiect_TP.Proiect_TP.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proiect_TP.Proiect_TP.DAL
{
    public class ChessLobbyDAL
    {
        private static readonly log4net.ILog log = log4net.LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        private static ContextLobby _context = new ContextLobby();

        public ChessLobbyDAL()
        {
            try
            {
                ChessLobby cl = _context.ChessLobby.ToList().ElementAt(0);

            }catch(Exception ex)
            {
                AddEmptyRoom();
            }
        }

        internal void AddEmptyRoom()
        {
            ChessLobby cl = new ChessLobby();
            cl.Id = Guid.NewGuid();
            cl.Turn = "White";
            _context.ChessLobby.Add(cl);
            _context.SaveChanges();
        }

        internal Guid GetLobbyTable()
        {
            ChessLobby cl = _context.ChessLobby.ToList().ElementAt(0);
            return cl.gameGUID;
        }
        internal Side.SideType GetTurn()
        {
            ChessLobby cl = _context.ChessLobby.ToList().ElementAt(0);
            if(cl.Turn == "White")
            {
                return Side.SideType.White;
            }
            return Side.SideType.Black;
        }

        internal void ReversTurn()
        {
            ChessLobby cl = _context.ChessLobby.ToList().ElementAt(0);
            if (cl.Turn == "White")
            {
                _context.ChessLobby.Remove(cl);
                _context.SaveChanges();
                cl.Turn = "Black";
                _context.ChessLobby.Add(cl);
                _context.SaveChanges();
            }
            else
            {
                _context.ChessLobby.Remove(cl);
                _context.SaveChanges();
                cl.Turn = "White";
                _context.ChessLobby.Add(cl);
                _context.SaveChanges();
            }
        }

        internal User lobbyUser1()
        {
            ChessLobby cl = _context.ChessLobby.ToList().ElementAt(0);
            UserBLL userBll = new UserBLL();
            User user = userBll.GetUserById(cl.user1GUID);
            return user;
        }
        internal User lobbyUser2()
        {
            ChessLobby cl = _context.ChessLobby.ToList().ElementAt(0);
            UserBLL userBll = new UserBLL();
            User user = userBll.GetUserById(cl.user2GUID);
            return user;
        }

        internal void finishLobby()
        {
            _context = new ContextLobby();
            ChessLobby chessLobby = new ChessLobby();
            chessLobby = _context.ChessLobby.ToList().ElementAt(0);
            ChessLobby newChessLobby = new ChessLobby();
            newChessLobby.Id = chessLobby.Id;
            newChessLobby.Turn = "White";
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
                        try
                        {
                            ChessLobby newLobby = new ChessLobby();
                            newLobby.Id = cl.Id;
                            _context.ChessLobby.Remove(cl);
                            _context.SaveChanges();

                            newLobby.user1GUID = user.Id;
                            _context.ChessLobby.Add(newLobby);
                            _context.SaveChanges();
                        }
                        catch(Exception ex)
                        {
                            log.Info(ex.StackTrace);
                        }
                    
                    }
                    else
                    {
                        try
                        {
                            ChessLobby newLobby = new ChessLobby();
                            ChessTableBLL chs = new ChessTableBLL();
                            newLobby.Id = cl.Id;
                            newLobby.user1GUID = cl.user1GUID;
                            newLobby.Turn = cl.Turn;
                            newLobby.user2GUID = user.Id;
                            newLobby.gameGUID = chs.TableID();


                            _context.ChessLobby.Remove(cl);
                            _context.SaveChanges();
                            _context.ChessLobby.Add(newLobby);
                            _context.SaveChanges();
                        }catch(Exception ex)
                        {
                            log.Info(ex.StackTrace);
                        }
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