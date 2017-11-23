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
            return View();
        }
    }
}