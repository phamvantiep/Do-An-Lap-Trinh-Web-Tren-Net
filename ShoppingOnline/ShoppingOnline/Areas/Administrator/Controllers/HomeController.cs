using ShoppingOnline.Model;
using ShoppingOnline.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ShoppingOnline.Areas.Administrator.Controllers
{
    public class HomeController : Controller
    {
        UserRepository userRepo = new UserRepository();
        // GET: Administrator/Home
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username, string password)
        {
            User user = userRepo.GetAll().SingleOrDefault(x => x.UserName == username
            && x.Password == password);
            if(user != null)
            {
                Session["userid"] = user.UserId;
                Session["username"] = user.UserName;
                Session["fullname"] = user.FullName;
                Session["avatar"] = user.Avatar;
                return RedirectToAction("Index");
            }
            ViewBag.error = "Bạn nhập sai, vui lòng nhập lại!";
            return View(user);
        }
    }
}