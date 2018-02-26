using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace OutputCacheExample.Controllers
{
    public class HomeController : Controller
    {
        private static int x = 9;
        [OutputCache(Duration = 30, Location = OutputCacheLocation.Server)]
        public string Index()
        {
            x++;

            return x.ToString();
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
    }
}