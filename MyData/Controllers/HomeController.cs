using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyData.Models;

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
            PersonalContact me = new PersonalContact();
            me.Name = "Kanchana Senadheera";
            me.WorkAddress = "hSenid Software International, 50, Ward Place, Colombo 07.";
            me.WorkPhone = "+94112699754";
            me.MobilePhone = "+94778007867";
            me.Email = "kanchana@hsenidlanka.com";

            return View(me);
        }
    }
}