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
    public class HomeController : Controller
    {

        public static Cell sourceCell;
        public static Cell destCell;

        public ActionResult Index(User user)
        {
            if( user.Name!= null && user.Password!=null)
            {
                UserBLL userBll = new UserBLL();
                if (userBll.CheckPassword(user.Name,user.Password))
                {
                    user = userBll.GetUserByEmailPass(user);
                    Session["ID"] = user.Id;
                    return RedirectToAction("Index", "ChessGameLobby",user);
                }
                
            }
            return View(user);
        }
        public ActionResult Logout()
        {
            Session["ID"] = null;
            return RedirectToAction("Index", "Home");
        }
        public ActionResult Index2(string id)
        {
            ChessTableBLL ct = new ChessTableBLL();
            ChessBoard cb = ct.GetChessBoard(ct.GetTables()[0]);
            ChessGameRulesManager rulesManager = new ChessGameRulesManager(cb);
            
            List<int> rowAndCol = SplitRowAndCol(id);
            List<string> possibleMoves = new List<string>();
            if (sourceCell == null)
            {
                sourceCell = cb.GetCell(rowAndCol[0], rowAndCol[1]);
                if(sourceCell.IsEmpty())
                {
                    sourceCell = null;
                    destCell = null;
                }
                
                
            }
            else
            {
                possibleMoves = rulesManager.GetPossibleMoves(sourceCell);
                destCell = cb.GetCell(rowAndCol[0], rowAndCol[1]);
                bool ok = rulesManager.IsValidMove(cb.GetKey(destCell),possibleMoves);

                if (ok)
                {
                   cb = rulesManager.ExecuteMove(new PieceMove(sourceCell, destCell));
                   ct.UpdateTable(cb);
                    
                }
                sourceCell = null;
                destCell = null;
            }

            

            return RedirectToAction("Index", "ChessGame");
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public List<int> SplitRowAndCol(string rowandcol)
        {
            List<int> result = new List<int>();
            List<string> strings = new List<string>();
            strings = rowandcol.Split(',').ToList();
            result.Add( Int32.Parse(strings[0]));
            result.Add(Int32.Parse(strings[1]));
            return result;
        }
    }
}