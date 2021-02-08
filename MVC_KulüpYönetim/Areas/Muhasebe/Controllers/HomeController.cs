using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_KulüpYönetim.Areas.Muhasebe.Controllers
{
    [Authorize(Roles = "Yonetim,Muhasebe")]
    public class HomeController : Controller
    {
        // GET: Muhasebe/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}