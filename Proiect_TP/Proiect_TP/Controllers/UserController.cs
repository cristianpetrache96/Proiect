using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proiect_TP.Models;
using Proiect_TP.BLL;

namespace Proiect_TP.Controllers
{
    public class UserController : Controller
    {
        UserBLL userService = new UserBLL();
        ScoreBLL scoreService = new ScoreBLL();
        // GET: User
        public ActionResult Index()
        {
           
            //users.Add(new User { Name = "Cristian", Email = "cristian.petrache@yahoo.com", Id = new Guid(), Password = "123456" });
            return View(userService.GetUsers());
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (TryUpdateModel<User>(user))
            {
                Score score = new Score();
                user.Id = Guid.NewGuid();
                score.id = user.Id;
                score.scor_list.Add(0);
                userService.AddUser(user);
                scoreService.Addscore(score);
            }
            return RedirectToAction("Index");
        }

        
        
    }
}