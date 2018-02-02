﻿using System;
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

            ChessGame ch = new ChessGame();

            ch.Board = ct.GetChessBoard(ct.GetTables().ToList()[0]);
            return View(ch);
        }

    }
}