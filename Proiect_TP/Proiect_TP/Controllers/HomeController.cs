using Proiect_TP.BLL;
using Proiect_TP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proiect_TP.Controllers
{
    public class HomeController : Controller
    {
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
            Console.Write(id);
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
    }
}