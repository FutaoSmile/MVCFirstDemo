using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewData["time"] = DateTime.Now;
            ViewBag.name = "老司机";
            return View();
        }

        public ActionResult About()
        {
            ViewData["hello"] = "Hello World";
            return View();
        }
    }
}