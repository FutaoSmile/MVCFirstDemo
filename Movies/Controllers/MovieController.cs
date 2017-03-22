using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Movies.Models;
using MovieEF;
namespace Movies.Controllers
{
    public class MovieController : Controller
    {
        MovieDBContext dbContext = new MovieDBContext();
        // GET: Movie
        public ActionResult Index()
        {
            //ViewData.Model = dbContext.Movies.AsEnumerable();
            return View(dbContext.Movies.ToList());
        }

        public ActionResult ListTemplete(string list, string searchString)
        {
            int val = Convert.ToInt32(list);
            MovieDBContext dbContext = new MovieDBContext();
            var result = from u in dbContext.Movies
                         select u;
            List<SelectListItem> selectList = new List<SelectListItem>();
            foreach (var a in dbContext.Levels) {

                selectList.Add(new SelectListItem() { Text= a.LevelName ,Value=a.LevelID.ToString()});
            }
            ViewData["list"] = selectList;
            if (!string.IsNullOrEmpty(searchString))
            {
                result = result.Where(u => u.Title == searchString);
            }
            if (!string.IsNullOrEmpty(list))
            {
                result = result.Where(u => u.level.LevelID == val);
            }
            return View(result.ToList());
            //return Content(result.ToList());
        }


        [ActionName("ListTemplete")]
        [HttpPost]
        public ActionResult ListTempleteA(string list, string searchString)
        {
            int val = Convert.ToInt32(list);
            MovieDBContext dbContext = new MovieDBContext();
            var result = from u in dbContext.Movies
                         select u;
            List<SelectListItem> selectList = new List<SelectListItem>();
            foreach (var a in dbContext.Levels)
            {

                selectList.Add(new SelectListItem() { Text = a.LevelName, Value = a.LevelID.ToString() });
            }
            ViewData["list"] = selectList;
            if (!string.IsNullOrEmpty(searchString))
            {
                result = result.Where(u => u.Title == searchString);
            }
            if (!string.IsNullOrEmpty(list))
            {
                result = result.Where(u => u.level.LevelID == val);
            }
            return Content(result);
        }


            public ActionResult Create()
        {
            MovieDBContext dbContext = new MovieDBContext();
            ViewBag.level = new SelectList(dbContext.Levels, "LevelName", "LevelName");
            return View();
        }
        [HttpPost]
        public ActionResult Create(Movie movie)
        {
            MovieDBContext dbContext = new MovieDBContext();
            Level l = dbContext.Levels.FirstOrDefault(u => u.LevelName == movie.level.LevelName);
            movie.level = l;
            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
            return RedirectToAction("ListTemplete");
        }

        public ActionResult Details(int id)
        {
            ViewData.Model = dbContext.Movies.Find(id);
            return View();
        }
        public ActionResult Delete(int? id)
        {
            MovieDBContext dbContext = new MovieDBContext();
            Movie movie = dbContext.Movies.FirstOrDefault(u => u.ID == id);
            ViewData.Model = movie;
            return View();
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteMovie(Movie mo)
        {
            MovieDBContext dbContext = new MovieDBContext();
            Movie m = dbContext.Movies.FirstOrDefault(u => u.ID == mo.ID);
            dbContext.Movies.Remove(m);
            dbContext.SaveChanges();
            return RedirectToAction("ListTemplete");
        }

        public ActionResult Edit(int? id)
        {
            MovieDBContext dbContext = new MovieDBContext();
            //ViewData.Model = dbContext.Movies.FirstOrDefault(u => u.ID == id);
            Movie movie = dbContext.Movies.Find(id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
        }

        public ActionResult EditTemplate(int? id)
        {
            MovieDBContext dbContext = new MovieDBContext();
            //ViewData.Model = dbContext.Movies.FirstOrDefault(u => u.ID == id);
            Movie movie = dbContext.Movies.Find(id);
            //Level l = dbContext.Levels.FirstOrDefault(u => u.LevelName == movie.level.LevelName);
            //movie.level = l;

            List<SelectListItem> sl = new List<SelectListItem>();

            foreach (var a in dbContext.Levels)
            {
                if (a.LevelName == movie.level.LevelName)
                {
                    sl.Add(new SelectListItem() { Text = a.LevelName.ToString(), Selected = true });
                }
                else
                {
                    sl.Add(new SelectListItem()
                    {
                        Text = a.LevelName.ToString()
                    });
                }
            }
            //foreach (var a in dbContext.Levels)
            //{
            //    sl.Add(new SelectListItem() {Text= a.LevelName.ToString() });
            //}
            ViewBag.level = sl;
            if (movie == null)
            {
                return HttpNotFound();
            }
            dbContext.Entry(movie).State = System.Data.Entity.EntityState.Unchanged;
            return View(movie);
        }
        [HttpPost]
        public ActionResult EditTemplate(Movie movie)
        {
            MovieDBContext dbContext = new MovieDBContext();
            //dbContext.Entry(movie).State = System.Data.Entity.EntityState.Unchanged;
            Movie m = dbContext.Movies.FirstOrDefault(u => u.ID == movie.ID);
            m.Price = movie.Price;
            m.ReleaseTime = movie.ReleaseTime.Date;
            m.Title = movie.Title;
            m.level = dbContext.Levels.FirstOrDefault(u => u.LevelName == movie.level.LevelName);
            //使用FirstOrDefault就不用再添加这一行代码了 
            //dbContext.Entry(m).State = System.Data.Entity.EntityState.Modified;

            //movie.level = dbContext.Levels.FirstOrDefault(u => u.LevelName == movie.level.LevelName);
            //dbContext.Entry(movie).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
            return RedirectToAction("ListTemplete");
        }

        public ActionResult DeleteTemplate(int id)
        {
            Movie movie = dbContext.Movies.Find(id);
            ViewData.Model = movie;
            return View();
        }

        [HttpPost]
        [ActionName("DeleteTemplate")]
        public ActionResult DeleteTemplateA(int id)
        {
            Movie movie = dbContext.Movies.Find(id);
            //方式一
            //dbContext.Movies.Remove(movie);
            //方式二
            dbContext.Entry(movie).State = System.Data.Entity.EntityState.Deleted;
            dbContext.SaveChanges();
            return RedirectToAction("ListTemplete");
        }

        public ActionResult Search(Movie movie)
        {

            return View();
        }
        [HttpPost]
        [ActionName("Search")]
        public ActionResult SearchResult(Movie movie)
        {

            return View();
        }
    }
}