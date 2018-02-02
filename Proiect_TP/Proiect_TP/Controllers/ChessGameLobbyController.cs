using Proiect_TP.BLL;
using Proiect_TP.Models;
using Proiect_TP.Proiect_TP.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proiect_TP.Controllers
{
    public class ChessGameLobbyController : Controller
    {
        // GET: ChessGameLobby
        public ActionResult Index(User user)
        {
            
                ChessLobbyBLL cl = new ChessLobbyBLL();
                if (cl.GetLobbyTable() != new Guid())
                {
                    if ((Guid)Session["ID"] == cl.lobbyUser1().Id || (Guid)Session["ID"] == cl.lobbyUser2().Id )
                    return RedirectToAction("Index", "ChessGame");
                }
            
            return View(user);
        }


        public ActionResult InLobby()
        {
            ChessLobbyBLL chessLobbyBLL = new ChessLobbyBLL();
            User user = new User();
            user.Id = (Guid)Session["ID"];
            //chessLobbyBLL.finishLobby();
            if (chessLobbyBLL.addUser(user))
            {
                Session["InLobby"] = true;
            }
            if (chessLobbyBLL.isEmpty())
            {
               
                return RedirectToAction("Index");
            }
            if (Session["InLobby"]!=null)
            if ((bool)Session["InLobby"] == true)
            {
                return RedirectToAction("Index", "ChessGame");
            }
            return RedirectToAction("Index");
        }

    }
}