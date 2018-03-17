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
    public class CourseMaterialsController : Controller
    {
        private sunodiaEntities db = new sunodiaEntities();

        // GET: CourseMaterials
        public ActionResult Index(int? courseId)
        {
            var model = new CourseMaterialViewModel();
            model.Course = db.Courses.Where(x => x.Id == courseId).First();
            model.CourseId = courseId ?? 0;
            var courseMaterials = db.CourseMaterials.Include(c => c.Cours).Include(c => c.Vendor).Where(x=>x.CourseId== courseId);
            model.Materials = courseMaterials.ToList();
            var vendors = db.Vendors
                .Select(x =>
                     new SelectListItem
                     {
                         Value = x.Id.ToString(),
                         Text = x.VendorName
                     });
            model.AllVendors = new SelectList(vendors, "Value", "Text");
            return View(model);
        }


        // GET: CourseMaterials/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseMaterial courseMaterial = db.CourseMaterials.Find(id);
            if (courseMaterial == null)
            {
                return HttpNotFound();
            }
            return View(courseMaterial);
        }

        // GET: CourseMaterials/Create
        public ActionResult Create(int? courseId)
        {
            ViewBag.CourseId = courseId;
            ViewBag.VendorId = new SelectList(db.Vendors, "Id", "VendorName");
            return View();
        }

        // POST: CourseMaterials/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CourseId,MaterialName,CostToStudent,CostToOrg,PurchaseOptions,VendorId")] CourseMaterial courseMaterial)
        {
            var courseId = courseMaterial.CourseId;
            if (ModelState.IsValid)
            {
                db.CourseMaterials.Add(courseMaterial);
                db.SaveChanges();
                return RedirectToAction("Index", new { courseId = courseId });
            }

            ViewBag.CourseId = courseMaterial.CourseId;
            ViewBag.VendorId = new SelectList(db.Vendors, "Id", "VendorName", courseMaterial.VendorId);
            return View(courseMaterial);
        }

        // GET: CourseMaterials/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseMaterial courseMaterial = db.CourseMaterials.Find(id);
            if (courseMaterial == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", courseMaterial.CourseId);
            ViewBag.VendorId = new SelectList(db.Vendors, "Id", "VendorName", courseMaterial.VendorId);
            return View(courseMaterial);
        }

        // POST: CourseMaterials/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CourseId,MaterialName,CostToStudent,CostToOrg,PurchaseOptions,VendorId")] CourseMaterial courseMaterial)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseMaterial).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index", new { courseId = courseMaterial.CourseId });
            }
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", courseMaterial.CourseId);
            ViewBag.VendorId = new SelectList(db.Vendors, "Id", "VendorName", courseMaterial.VendorId);
            return View(courseMaterial);
        }

        // GET: CourseMaterials/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseMaterial courseMaterial = db.CourseMaterials.Find(id);
            if (courseMaterial == null)
            {
                return HttpNotFound();
            }
            return View(courseMaterial);
        }

        // POST: CourseMaterials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseMaterial courseMaterial = db.CourseMaterials.Find(id);
            db.CourseMaterials.Remove(courseMaterial);
            var courseId = courseMaterial.CourseId;
            db.SaveChanges();
            return RedirectToAction("Index", new { CourseId = courseId });
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
