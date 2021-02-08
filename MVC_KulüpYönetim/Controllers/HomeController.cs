using MVC_KulüpYönetim.Models.Context;
using MVC_KulüpYönetim.Models.Entity;
using MVC_KulüpYönetim.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace MVC_KulüpYönetim.Controllers
{
    public class HomeController : Controller
    {
        ProjectDbContext db = new ProjectDbContext();
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
        public ActionResult Login(LoginVM loginVM)
        {
            if (ModelState.IsValid)
            {
                Fan fan = db.Fans.Where(x => x.FanName == loginVM.FanName && x.Password == loginVM.Password).FirstOrDefault();
                if (fan != null)
                {
                    FormsAuthentication.SetAuthCookie(fan.FanName, true);
                }
            }
            return RedirectToAction("Index");
        }
    }
}