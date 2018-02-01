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
            return View(user);
        }

        public ActionResult InLobby()
        {
            ChessLobbyBLL chessLobbyBLL = new ChessLobbyBLL();
            User user = new User();
            user.Id = (Guid)Session["ID"];
           // chessLobbyBLL.finishLobby();
            if (chessLobbyBLL.addUser(user))
            {
                Session["InLobby"] = true;
            }
            //TODO in caz de intra al treilea
            if (chessLobbyBLL.isEmpty())
            {
               
                return RedirectToAction("Index");
            }
            if ((bool)Session["InLobby"] == true)
            {
                // is sesion "in loby" is tru atunci , daca nu ramane pe pagina
                return RedirectToAction("Index", "ChessGame");
            }
            return RedirectToAction("Index");
        }
    }
}