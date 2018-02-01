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
    }
}