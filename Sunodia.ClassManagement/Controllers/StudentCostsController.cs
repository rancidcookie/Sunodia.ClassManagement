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
    public class StudentCostsController : Controller
    {
        private fhiEntities db = new fhiEntities();

        // GET: StudentCosts
        public ActionResult Index()
        {
            return View(db.StudentCosts.ToList());
        }

        // GET: StudentCosts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentCost studentCost = db.StudentCosts.Find(id);
            if (studentCost == null)
            {
                return HttpNotFound();
            }
            return View(studentCost);
        }

        // GET: StudentCosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: StudentCosts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description,DefaultAmount")] StudentCost studentCost)
        {
            if (ModelState.IsValid)
            {
                db.StudentCosts.Add(studentCost);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(studentCost);
        }

        // GET: StudentCosts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentCost studentCost = db.StudentCosts.Find(id);
            if (studentCost == null)
            {
                return HttpNotFound();
            }
            return View(studentCost);
        }

        // POST: StudentCosts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,DefaultAmount")] StudentCost studentCost)
        {
            if (ModelState.IsValid)
            {
                db.Entry(studentCost).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(studentCost);
        }

        // GET: StudentCosts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            StudentCost studentCost = db.StudentCosts.Find(id);
            if (studentCost == null)
            {
                return HttpNotFound();
            }
            return View(studentCost);
        }

        // POST: StudentCosts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            StudentCost studentCost = db.StudentCosts.Find(id);
            db.StudentCosts.Remove(studentCost);
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
