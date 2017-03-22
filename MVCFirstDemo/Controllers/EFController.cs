using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstDemo.Models;
using System.Linq.Expressions;
using System.Web.UI.WebControls.Expressions;

namespace MVCFirstDemo.Controllers
{
    public class EFController : Controller
    {
        Model1Container dbContext=new Model1Container();
        // GET: EF
        public ActionResult Index()
        {
            //    Student s = dbContext.StudentSet.Find(1);
            //    Student b = dbContext.StudentSet.FirstOrDefault(u => u.Id == 1);

            //    dbContext.Entry(s).State = System.Data.Entity.EntityState.Deleted;
            return View();
        }
    }
}