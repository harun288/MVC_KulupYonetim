using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_KulüpYönetim.Areas.Yönetim.Controllers
{
    [Authorize(Roles = "Yonetim,")]
    public class HomeController : Controller
    {
        // GET: Yönetim/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}