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
        static List<string> possibleMoves;

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
            
            ChessLobbyBLL chessLobby = new ChessLobbyBLL();
            Side.SideType turn =  chessLobby.GetTurn();
            User userLobby1 = chessLobby.lobbyUser1();
            User userLobby2 = chessLobby.lobbyUser2();
            if ((turn == Side.SideType.White && userLobby1.Id == (Guid)Session["ID"]) || 
                (turn == Side.SideType.Black && userLobby2.Id == (Guid)Session["ID"]))
            {

                ChessTableBLL ct = new ChessTableBLL();
                ChessBoard cb = ct.GetChessBoard(ct.GetTables()[0]);
                ChessGameRulesManager rulesManager = new ChessGameRulesManager(cb);

                List<int> rowAndCol = SplitRowAndCol(id);
                 
                if (sourceCell == null)
                {
                    possibleMoves = new List<string>();
                    sourceCell = cb.GetCell(rowAndCol[0], rowAndCol[1]);
                    if (sourceCell.IsEmpty())
                    {
                        sourceCell = null;
                        destCell = null;
                    }
                    else if (sourceCell.Piece.Side.SideTip != turn)
                    {
                        sourceCell = null;
                    }
                    if (sourceCell != null)
                    {
                        // if (rulesManager.IsUnderCheck(turn))
                        // {
                        //    possibleMoves = rulesManager.GetOnlyLegalMoves(sourceCell);
                        // }
                        // else
                        // {
                        possibleMoves = rulesManager.GetPossibleMoves(sourceCell);
                    }


                }
                else
                {
                    destCell = cb.GetCell(rowAndCol[0], rowAndCol[1]);
                    bool ok = rulesManager.IsValidMove(cb.GetKey(destCell), possibleMoves);

                    if (ok)
                    {
                        cb = rulesManager.ExecuteMove(new PieceMove(sourceCell, destCell));
                        ct.UpdateTable(cb);
                    }
                    sourceCell = null;
                    destCell = null;
                    chessLobby.ReversTurn();
                }
                
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