using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC5WEB.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "To jest stronka w MVC5!!!!";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.TheMessage = "Masz jakiś problem.Napisz do nas!";

            return View();
        }


        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.TheMessage = "Dzięki mamy twoją wiadomość!!";

            return View();
        }

        public ActionResult Foo()
        {
            return View("About");
        }

        public ActionResult Serial(string letterCase)
        {
            var serial = "ASPNETMVC%ATM1";

            if (letterCase == "lower") {
                return Content(serial.ToLower());
            }
            else{
                // return Content(serial);
                return Json(new { name = "serial", value = serial },JsonRequestBehavior.AllowGet);

            }
        }
    }
}
