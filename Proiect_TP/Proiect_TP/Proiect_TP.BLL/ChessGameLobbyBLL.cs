using Proiect_TP.DAL;
using Proiect_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proiect_TP.BLL
{
    public class ChessGameLobbyBLL
    {
        ChessGameLobbyDAL cgl = new ChessGameLobbyDAL();

        internal bool addUser(User user)
        {
            return cgl.addUser(user);
        }

        internal bool isEmpty()
        {
            return cgl.isEmpty();
        }
    }
}