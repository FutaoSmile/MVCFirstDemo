using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Web;
using System.Web.Mvc;
using MVCFirstDemo.Models;

namespace MVCFirstDemo.Controllers
{
    public class BaseController : Controller
    {
        // GET: Base
        public Model1Container dbContext {
            get
            {
                Model1Container dbContext = CallContext.GetData("DB") as Model1Container;
                if (dbContext == null)
                {
                    dbContext = new Model1Container();
                    CallContext.SetData("DB", dbContext);
                }
                return dbContext;
            }
        }
    }
}