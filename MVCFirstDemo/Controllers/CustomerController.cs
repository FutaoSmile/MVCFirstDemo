using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstDemo.Models;

namespace MVCFirstDemo.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        #region 弱类型
        public ActionResult ShowCustomer(int id)
        {
            //根据Id获取当前的Customer信息，并且展示到View
            Customer customer = new Customer() { Id = id, SName = "Fnatic", Email = "1185@qq.com", Age = 21 };
            //弱类型，给到前台再强转到Customer类型
            ViewData["customer"] = customer;
            return View();
        }
        #endregion

        #region 强类型
        public ActionResult Detail(int id)
        {
            Customer customer = new Customer() { Id = id, SName = "Fnatic", Email = "1185@qq.com", Age = 21 };
            ViewData.Model = customer;

            
            return View();
        }
        #endregion

        public ActionResult Edit()
        {
            return View();
        }
    }
}