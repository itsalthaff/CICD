using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JenkinsCICDdemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {                                                                                                                
            ViewBag.Message = "Hello asdas Woasdarldxcvxcvxccvjhykjghjmgjhmtg!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact asasd page.";

            return View();
        }
    }
}