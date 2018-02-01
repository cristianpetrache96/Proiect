using Proiect_TP.DBContext;
using Proiect_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Proiect_TP.DAL
{
    public class ChessLobbyDAL
    {

        private static ContextLobby _context = new ContextLobby();

        public bool addLobby()
        {
            try
            {
                _context = new ContextLobby();
                ChessLobby cl = new ChessLobby();
                cl.Id = Guid.NewGuid();
                cl.gameGUID = Guid.NewGuid();
                cl.user1GUID = Guid.NewGuid();
                _context.ChessLobby.Add(cl);
                _context.SaveChanges();

                return true;
            }catch(Exception ex)
            {
                return false;
            }
        }
    }
}