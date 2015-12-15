using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Augtech.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = string.Empty;

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "August Technologies, Inc.";

            return View();
        }
    }
}