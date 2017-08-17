using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyData.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index() {
            return View();
        }

        public ActionResult Bio()
        {
            ViewBag.Name = "Kanchana Senadheera";
            ViewBag.Profession = "Software Engineer";
            ViewBag.Dob = "10/01/1990";
            ViewBag.HomeTown = "Kandy";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}