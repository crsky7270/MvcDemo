using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RuanYun.Logger;
namespace MvcDemo.Controllers
{
   public class HomeController : Controller
   {
      public ActionResult Index()
      {
         ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
         Log.Write("some one into index action", MessageType.Info, typeof(HomeController));
         ViewBag.BasicNo = 2;
         return View();
      }

      public ActionResult About()
      {
         ViewBag.Message = "Your app description page.";

         return View();
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";

         return View();
      }

      public ActionResult GetImageResult()
      {
         var imgPath = @"C:\Users\dun\Pictures\butterfly.jpg";
         return File(imgPath, "image/jpg");
      }

      public ActionResult GetJavaScript()
      {
         return JavaScript("alert('qwe');");
      }
   }
}
