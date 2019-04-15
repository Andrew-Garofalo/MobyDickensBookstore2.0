using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace MobyDickensBookstore2._0.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        //[Authorize(Roles = "Admin")]
        [Authorize]
        public ActionResult Index()
        {
            //return Json((User.Identity as ClaimsIdentity).Claims.Select(c => new { key = c.Type, value = c.Value }), JsonRequestBehavior.AllowGet);
            return View();
        }

        [HttpGet]
        public ActionResult About()
        {
            ViewBag.Message = "Moby Dickens Bookstore 2.0";

            return View();
        }

        [HttpGet]
        public ActionResult Contact()
        {
            ViewBag.Message = "Tell us what you think:";

            return View();
        }

        [HttpPost]
        public ActionResult Contact(string message)
        {
            ViewBag.Message = "Thanks for the feedback!";

            return PartialView("_ThanksForFeedback");
        }

    }
}