using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sunodia.ClassManagement.Models;

namespace Sunodia.ClassManagement.Controllers
{
    public class AnalysisController : Controller
    {
        private fhiEntities db = new fhiEntities();

        // GET: Analysis
        public ActionResult Index(int? id)
        {
            if(id == null)
                return RedirectToAction("PickClass");   
            else
            {
                ViewBag.ClassId = id;
                return View();
            }

        }

        public ActionResult PickClass()
        {
            //ViewBag.CourseFormatId = new SelectList(db.CourseFormats, "Id", "Format", "");
            //var SelectCourse = new SelectList(db.Courses, "Id", "CourseName");
            //SelectCourse.Default("Select Course", "");
            //ViewBag.CourseId = SelectCourse;

            //return View();
            PickClassViewModel vm = new PickClassViewModel();
            vm.Classes = new SelectList(db.Events, "Id", "CourseId");

            return View(vm);
        }
        [HttpPost]
        public ActionResult ViewClass(PickClassViewModel result)
        {
            var test = result.SelectedClass;

            return View();
        }

        public ActionResult Review(int? classId)
        {
            var parm = classId ?? 0;
            var @results = db.GetAnalysis(parm);
            return View(@results);
        }

    }
}