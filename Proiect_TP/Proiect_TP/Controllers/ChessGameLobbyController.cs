using Proiect_TP.BLL;
using Proiect_TP.Models;
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

        public ActionResult InLobby(User user)
        {
          //  ChessGameLobbyBLL cgb = new ChessGameLobbyBLL();
            bool ok;
        //    ok = cgb.addUser(user);
        //    if (ok)
            {
         //       Session["InLobby"] = true;
            }
        //    if (cgb.isEmpty())
            {

        //        return RedirectToAction("Index");
            }
      //      else
            {
                return RedirectToAction("Index", "ChessGame");
            }
        }
    }
}