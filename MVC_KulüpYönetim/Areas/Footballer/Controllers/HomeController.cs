using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_KulüpYönetim.Areas.Footballer.Controllers
{
    [Authorize(Roles = "Yonetim,Footballer")]
    public class HomeController : Controller
    {
        // GET: Footballer/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}