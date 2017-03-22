 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstDemo.Controllers
{
    public class UserInfoController : Controller
    {
        // GET: UserInfo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult UserRegist()
        {
            return View();
        }

        public ActionResult ProcessUserInfo(string txtName,string txtPwd,Info userA)
        {
            //如何拿到用户提交来的表单内容呢

            #region  方法一：获取前台的数据
            string UserName = Request["txtName"];
            string UserPwd = Request["txtPwd"];
            #endregion

            #region 方法二：获取前台的数据（此方法要传入参数FormCollection collection）
            //string str = collection["txtName"];
            #endregion

            //方法三：直接在函数参数里指定前台的name

            //return Content()，往前台输出一个字符串
            return Content("OK" + "</br>" + UserName + "</br>" + UserPwd + "</br>" + "OK" + "</br>" + txtName + "</br>" + txtPwd + "</br>"+"----------"+userA.txtPwd+userA.txtName);
            ////等价于
            //Response.Write("OK,Im Response");
            //Response.End();
        }

        public class Info
        {
            public string txtName { get; set; }
            public string txtPwd { get; set; }
        }
    }
}