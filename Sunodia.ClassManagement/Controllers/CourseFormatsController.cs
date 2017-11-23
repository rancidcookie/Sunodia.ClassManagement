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
    public class CourseFormatsController : Controller
    {
        private sunodiaEntities db = new sunodiaEntities();

        // GET: CourseFormats
        public ActionResult Index()
        {
            var courseFormats = db.CourseFormats.Include(c => c.QBAccount);
            return View(courseFormats.ToList());
        }

        // GET: CourseFormats/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseFormat courseFormat = db.CourseFormats.Find(id);
            if (courseFormat == null)
            {
                return HttpNotFound();
            }
            return View(courseFormat);
        }

        // GET: CourseFormats/Create
        public ActionResult Create()
        {
            ViewBag.AccountId = new SelectList(db.QBAccounts, "Id", "Description");
            return View();
        }

        // POST: CourseFormats/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Format,AccountId")] CourseFormat courseFormat)
        {
            if (ModelState.IsValid)
            {
                db.CourseFormats.Add(courseFormat);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AccountId = new SelectList(db.QBAccounts, "Id", "Description", courseFormat.AccountId);
            return View(courseFormat);
        }

        // GET: CourseFormats/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseFormat courseFormat = db.CourseFormats.Find(id);
            if (courseFormat == null)
            {
                return HttpNotFound();
            }
            ViewBag.AccountId = new SelectList(db.QBAccounts, "Id", "Description", courseFormat.AccountId);
            return View(courseFormat);
        }

        // POST: CourseFormats/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Format,AccountId")] CourseFormat courseFormat)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseFormat).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AccountId = new SelectList(db.QBAccounts, "Id", "Description", courseFormat.AccountId);
            return View(courseFormat);
        }

        // GET: CourseFormats/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseFormat courseFormat = db.CourseFormats.Find(id);
            if (courseFormat == null)
            {
                return HttpNotFound();
            }
            return View(courseFormat);
        }

        // POST: CourseFormats/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CourseFormat courseFormat = db.CourseFormats.Find(id);
            db.CourseFormats.Remove(courseFormat);
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
