using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Practices.ServiceLocation;
using MvcDemo.IBusiness;
using MvcDemo.Model;

namespace MvcDemo.Controllers
{
   public class LoginController : Controller
   {
      //
      // GET: /Login/
      private IUserBLL _userBll;

      public LoginController()
      {
         _userBll = ServiceLocator.Current.GetInstance<IUserBLL>();
      }

      public ActionResult Index()
      {
         return View();
      }

      public JsonResult UserLogin(string account, string password)//string account, string password
      {
         //var loginUser = new User() { Email = account, Password = password };
         //var loginStatus = _userBll.Login(loginUser);  
         //return Json(new { status = loginStatus, errMsg = "" });
         return Json(new { status = 1, errMsg = "" });
      }
   }
}
