using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult Index()
        {
            ViewBag.Title = "My Title";
            return View();
        }

        public ActionResult Welcome(int? NO,string Name)
        {
            ViewBag.NO = NO;
            ViewBag.Name = Name;
            return View();
        }

        public ActionResult Hello()
        {
            DateTime date=DateTime.Now;
            return View(date);
        }
    }
}