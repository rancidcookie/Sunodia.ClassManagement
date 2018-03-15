using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sunodia.ClassManagement.Models;

namespace Sunodia.ClassManagement.Controllers
{
    public class CourseCertsController : Controller
    {
        private fhiEntities db = new fhiEntities();

        // GET: CourseCerts
        public ActionResult Index(int? courseId)
        {
            var model = new CourseCertViewModel();
            model.Course = db.Courses.Where(x => x.Id == courseId).First();
            model.CourseId = courseId ?? 0;

            var certs = db.Certificates
             .Select(x =>
                     new SelectListItem
                     {
                         Value = x.Id.ToString(),
                         Text = x.CertName
                     });
            model.AllCerts = new SelectList(certs, "Value", "Text");
            return View(model);
        }

        // GET: CourseCerts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseCert courseCert = db.CourseCerts.Find(id);
            if (courseCert == null)
            {
                return HttpNotFound();
            }
            return View(courseCert);
        }

        // GET: CourseCerts/Create
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var courseId = Convert.ToInt32(collection["CourseId"]);
                var certId = Convert.ToInt32(collection["CertId"]);
                var newCourseCert = new CourseCert() { CourseId = courseId, CertId = certId };
                db.CourseCerts.Add(newCourseCert);
                db.SaveChanges();
                return RedirectToAction("Index", new { CourseId = courseId });
            }
            catch(Exception ex)
            {
                var tmp = ex.ToString();
                return View();
            }
        }

        //// POST: CourseCerts/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,CertId,CourseId")] CourseCert courseCert)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        db.CourseCerts.Add(courseCert);
        //        db.SaveChanges();
        //        return RedirectToAction("Index");
        //    }

        //    ViewBag.CertId = new SelectList(db.Certificates, "Id", "CertName", courseCert.CertId);
        //    ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", courseCert.CourseId);
        //    return View(courseCert);
        //}

        // GET: CourseCerts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseCert courseCert = db.CourseCerts.Find(id);
            if (courseCert == null)
            {
                return HttpNotFound();
            }
            ViewBag.CertId = new SelectList(db.Certificates, "Id", "CertName", courseCert.CertId);
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", courseCert.CourseId);
            return View(courseCert);
        }

        // POST: CourseCerts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CertId,CourseId")] CourseCert courseCert)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseCert).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CertId = new SelectList(db.Certificates, "Id", "CertName", courseCert.CertId);
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", courseCert.CourseId);
            return View(courseCert);
        }

        // GET: CourseCerts/Delete/5
        public ActionResult Delete(int? id)
        {
            try
            {
                //var newPersonGroup = new PersonGroup() { PersonId = personId, GroupId = groupId };
                var tmpRec = db.CourseCerts.Find(id);
                var courseId = tmpRec.CourseId;
                db.CourseCerts.Remove(tmpRec);
                db.SaveChanges();
                return RedirectToAction("Index", new { CourseId = courseId });

            }
            catch
            {
                return View();
            }
        }

        // POST: CourseCerts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseCert courseCert = db.CourseCerts.Find(id);
            db.CourseCerts.Remove(courseCert);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
