using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstDemo.Models;

namespace MVCFirstDemo.Controllers
{
    public class AjaxController : Controller
    {
        Model1Container dbContext = new Model1Container();

        // GET: Ajax
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Details(int id)
        {
            if (dbContext.StudentSet.Find(id) == null)
            {
                return Content("Fail");
            }
            else
            {
                return Content("Success");
            }
        }
        public ActionResult Test()
        {
            return View();
        }
    }
}