using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieEF;

namespace Movies.Controllers
{
    public class LevelController : Controller
    {
        // GET: Level
        public ActionResult Index()
        {
            MovieDBContext dbContext = new MovieDBContext();
            ViewData.Model = dbContext.Levels;
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Level level)
        {
            MovieDBContext dbContext = new MovieDBContext();
            dbContext.Levels.Add(level);
            dbContext.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}