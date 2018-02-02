using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proiect_TP.Models;
using Proiect_TP.Proiect_TP.BLL;

namespace Proiect_TP.Controllers
{
    public class ChessGameController : Controller
    {

        // GET: ChessGame
        public ActionResult Index()

        {
            ChessTableBLL ct = new ChessTableBLL();
            ChessLobbyBLL cl = new ChessLobbyBLL();
           // User user1 = cl.lobbyUser1();
           // User user2 = cl.lobbyUser2();
            ChessGame ch = new ChessGame();
            //ct.UpdateTable(ch.Board);
            ch.Board = ct.GetChessBoard(ct.GetTables().ToList()[0]);
            ch._gameTurn =  cl.GetTurn();
            return View(ch);
        }


    }
}