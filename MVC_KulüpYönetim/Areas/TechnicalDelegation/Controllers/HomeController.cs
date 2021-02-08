using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_KulüpYönetim.Areas.TechnicalDelegation.Controllers
{
    [Authorize(Roles = "Yonetim,Technical Delegation")]
    public class HomeController : Controller
    {
        // GET: TechnicalDelegation/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}