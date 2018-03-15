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
    public class RegistrationTypesController : Controller
    {
        private fhiEntities db = new fhiEntities();

        // GET: RegistrationTypes
        public ActionResult Index()
        {
            return View(db.RegistrationTypes.ToList());
        }

        // GET: RegistrationTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrationType registrationType = db.RegistrationTypes.Find(id);
            if (registrationType == null)
            {
                return HttpNotFound();
            }
            return View(registrationType);
        }

        // GET: RegistrationTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RegistrationTypes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description")] RegistrationType registrationType)
        {
            if (ModelState.IsValid)
            {
                db.RegistrationTypes.Add(registrationType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(registrationType);
        }

        // GET: RegistrationTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrationType registrationType = db.RegistrationTypes.Find(id);
            if (registrationType == null)
            {
                return HttpNotFound();
            }
            return View(registrationType);
        }

        // POST: RegistrationTypes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description")] RegistrationType registrationType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(registrationType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(registrationType);
        }

        // GET: RegistrationTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RegistrationType registrationType = db.RegistrationTypes.Find(id);
            if (registrationType == null)
            {
                return HttpNotFound();
            }
            return View(registrationType);
        }

        // POST: RegistrationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            RegistrationType registrationType = db.RegistrationTypes.Find(id);
            db.RegistrationTypes.Remove(registrationType);
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
