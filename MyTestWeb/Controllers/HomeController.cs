using MyTestWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyTestWeb.Controllers
{
    //控制器：主要负责相应用户的输入，并且在相应时修改Model
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            HomeIndexModel model = new HomeIndexModel();
            model.Name = "后台复制ModelName";
            model.Title = "后台赋值ModelTitle";
            return View(model);


            //指定不同的视图方法：
            //同一目录下的VIew:
            //return View("URL ");


            //不同目录下的View
            //return View("~/完整路径.cshtml");
        }


        

        


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public string GetStr(string para)
        {
            return "hello world " + para;
        }
    }
}