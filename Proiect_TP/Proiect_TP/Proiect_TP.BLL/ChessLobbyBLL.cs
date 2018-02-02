using Proiect_TP.Models;
using Proiect_TP.Proiect_TP.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.Proiect_TP.BLL
{
    public class ChessLobbyBLL
    {
        ChessLobbyDAL cl = new ChessLobbyDAL();

        internal Guid GetLobbyTable()
        {
            return cl.GetLobbyTable();
        }
        internal Side.SideType GetTurn()
        {
            return cl.GetTurn();
        }
        internal void ReversTurn()
        {
            cl.ReversTurn();
        }
        internal bool addUser(User user)
        {
            return cl.addUser(user);
        }
         internal void finishLobby()
        {
            cl.finishLobby();
        }

        internal bool isEmpty()
        {
            return cl.isEmpty();
        }
        internal User lobbyUser1()
        {
            return cl.lobbyUser1();
        }
        internal User lobbyUser2()
        {
            return cl.lobbyUser2();
        }
    }
}