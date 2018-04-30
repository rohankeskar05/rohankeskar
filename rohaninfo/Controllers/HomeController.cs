using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace rohaninfo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to the Page.";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Know something about me.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Get in touch with me.";

            return View();
        }
    }
}
