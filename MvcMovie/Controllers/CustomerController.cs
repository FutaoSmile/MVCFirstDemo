using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcMovie.Models;

namespace MvcMovie.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetCustomer(int? id,FormCollection collection)
        {
            CustomerVM customer01 = new CustomerVM() { ID = 1, CustomerName = "Fnatic", CustomerNO = "001" };
            CustomerVM customer02 = new CustomerVM() { ID = 2, CustomerName = "Fnatic", CustomerNO = "002" };
            CustomerVM customer03 = new CustomerVM() { ID = 3, CustomerName = "Fnatic", CustomerNO = "003" };
            List<CustomerVM> customerVms=new List<CustomerVM>();
            customerVms.Add(customer01);
            customerVms.Add(customer02);
            customerVms.Add(customer03);
            if (collection["txtID"] == "")
            {
                return View();
            }
            else
            {
                id = Convert.ToInt16(collection["txtID"]);
                return View(customerVms.Find(u => u.ID == id));
            }
           
           

        }
    }
}