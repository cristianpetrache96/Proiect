using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proiect_TP.Models;

namespace Proiect_TP.Controllers
{
    public class ChessGameController : Controller
    {
        // GET: ChessGame
           public ActionResult Index()
           {
              ChessGame ch = new ChessGame();

              return View(ch);
          }
        [HttpPost]
        public ActionResult Index(string linia,string coloana) 
        {
            ChessGame ch = new ChessGame();

            return RedirectToAction("Index");
        }
    }
}