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
    public class QBAccountsController : Controller
    {
        private sunodiaEntities db = new sunodiaEntities();

        // GET: QBAccounts
        public ActionResult Index()
        {
            return View(db.QBAccounts.ToList());
        }

        // GET: QBAccounts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QBAccount qBAccount = db.QBAccounts.Find(id);
            if (qBAccount == null)
            {
                return HttpNotFound();
            }
            return View(qBAccount);
        }

        // GET: QBAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QBAccounts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Description")] QBAccount qBAccount)
        {
            if (ModelState.IsValid)
            {
                db.QBAccounts.Add(qBAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qBAccount);
        }

        // GET: QBAccounts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QBAccount qBAccount = db.QBAccounts.Find(id);
            if (qBAccount == null)
            {
                return HttpNotFound();
            }
            return View(qBAccount);
        }

        // POST: QBAccounts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Description,QBAccount1,IsCredit")] QBAccount qBAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qBAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qBAccount);
        }

        // GET: QBAccounts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QBAccount qBAccount = db.QBAccounts.Find(id);
            if (qBAccount == null)
            {
                return HttpNotFound();
            }
            return View(qBAccount);
        }

        // POST: QBAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QBAccount qBAccount = db.QBAccounts.Find(id);
            db.QBAccounts.Remove(qBAccount);
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
