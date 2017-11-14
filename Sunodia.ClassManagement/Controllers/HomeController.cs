using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sunodia.ClassManagement.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Sunodía Prayer Counseling";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Sunodía Prayer Counseling";

            return View();
        }

        public ActionResult ManageCourses()
        {
            ViewBag.Message = "Manage Courses";

            return View();
        }
        public ActionResult ManageLists()
        {
            ViewBag.Message = "Manage Lists";

            return View();
        }

        public ActionResult PageNotFound(string msg)
        {
            ViewBag.Msg = msg;
            return View();
        }
    }
}