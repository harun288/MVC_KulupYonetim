using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_KulüpYönetim.Areas.Outfitter.Controllers
{
    [Authorize(Roles = "Yonetim,Outfitter")]
    public class HomeController : Controller
    {
        // GET: Outfitter/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}