using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WorkDaily.Models;

namespace WorkDaily.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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

        public ActionResult Welcome()
        {
            //判斷裝置
            if (!MobileHelper.IsMobileDevice(Request.UserAgent))
            {
                return Redirect("https://github.com/DakHarry/WorkDaily");
            }
            return RedirectToAction("Index");
        }
    }
}