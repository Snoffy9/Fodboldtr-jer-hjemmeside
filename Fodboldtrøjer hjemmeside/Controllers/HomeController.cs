using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Fodboldtrøjer_hjemmeside.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Hvad er DK trøjer?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Kundeservice er åben:";

            return View();
        }
        public ActionResult BrowseTrøjer()
        {

            return View();
        }

    }
}