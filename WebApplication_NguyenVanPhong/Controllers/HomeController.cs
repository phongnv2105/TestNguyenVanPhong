using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication_NguyenVanPhong.Models;
using static WebApplication_NguyenVanPhong.Models.ViewModel.UserViewModel;

namespace WebApplication_NguyenVanPhong.Controllers
{
    public class HomeController : Controller
    {
        ConnectDB db = new ConnectDB();
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(User u)
        {
            if (ModelState.IsValid)
            {

                if (db.Users.Any(x=>x.Email==u.Email && x.Password==u.Password))
                {
                    Session["user"] = u.LastName;
                    return RedirectToAction("Index");

                }
                ModelState.AddModelError("", "Email or Password not Exist!");
                return View();
            }
            return View();
        }
    }
}