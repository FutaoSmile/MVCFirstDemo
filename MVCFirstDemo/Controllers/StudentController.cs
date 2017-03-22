using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstDemo.Models;

namespace MVCFirstDemo.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        Model1Container dbContext = new Model1Container();

        #region 学生列表
        public ActionResult Index()
        {
            ViewData.Model = dbContext.StudentSet.AsEnumerable();
            return View();
        }
        #endregion


        #region Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            dbContext.StudentSet.Add(student);
            dbContext.SaveChanges();
            return RedirectToAction("index");
        }
        #endregion

        #region Edit
        public ActionResult Edit(int id)
        {
            //ViewData.Model = dbContext.StudentSet.FirstOrDefault(u => u.Id == id);
            ViewData.Model = dbContext.StudentSet.Find(id);
            return View();
        }
        [HttpPost]
        public ActionResult Edit()
        {
            //dbContext.Entry(student).State = System.Data.Entity.EntityState.Modified;
            Student student =new Student();
            if (TryUpdateModel(student))
            {
                dbContext.Entry(student).State=EntityState.Modified;
                //dbContext.SaveChanges();
            }


            dbContext.SaveChanges();
            return RedirectToAction("Index");
            //连接到其他控制器下的方法  return RedirectToAction("Index","Home");
            //使用这个方法会报错  return Redirect("index");
        }
        #endregion

        #region Details


        public ActionResult Details(int id)
        {
            ViewData.Model = dbContext.StudentSet.Find(id);
            return View();
        }
        #endregion

        #region Delete
        public ActionResult Delete(int id)
        {
            ViewData.Model = dbContext.StudentSet.Find(id);
            return View();
        }

        [HttpPost]
        public ActionResult Delete(Student student)
        {
            dbContext.Entry(student).State = System.Data.Entity.EntityState.Deleted;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        #endregion
    }
}