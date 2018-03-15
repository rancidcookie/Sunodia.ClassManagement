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
    public class EventTransactionsController : Controller
    {
        private fhiEntities db = new fhiEntities();

        // GET: EventTransactions
        public ActionResult Index(int? eventId)
        {
            var eventTransactions = new eventTransactionViewModel();
            if (eventId != null)
            {
                int myId = eventId??0;
                eventTransactions.EventId = myId;
                eventTransactions.Transactions = db.vwEventTransactions.Where(x => x.EventId == eventId).ToList();
                eventTransactions.TransactionCategories = new SelectList(db.TransactionCategories, "Id", "Category");
                eventTransactions.Event = db.Events.Where(x => x.Id == myId).First();
            }
            //ViewBag.NickName = db.Events.Where(x => x.Id == eventId).First().NickName;
            return View(eventTransactions);
        }

        // GET: EventTransactions/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventTransaction eventTransaction = db.EventTransactions.Find(id);
            if (eventTransaction == null)
            {
                return HttpNotFound();
            }
            return View(eventTransaction);
        }

        // GET: EventTransactions/Create
        public ActionResult Create()
        {
            ViewBag.TransactionCategoryId = new SelectList(db.TransactionCategories, "Id", "Category");
            return View();
        }

        // POST: EventTransactions/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "EventId,Amount,FHICredit,Description,DateAdded,TransactionCategoryId")] FormCollection eventTransaction)
        {
            var eventId = Convert.ToInt32(eventTransaction["EventId"]);

            if (ModelState.IsValid)
            {
                int? transactionCategoryId = null;
                
                if (eventTransaction["CategoryId"] != null)
                    transactionCategoryId = Convert.ToInt32(eventTransaction["CategoryId"]);

                var newTransaction = new EventTransaction();
                newTransaction.Amount = Convert.ToDecimal(eventTransaction["Amount"]);
                newTransaction.EventId = eventId;
                newTransaction.FHICredit = Convert.ToBoolean(eventTransaction["FHICredit"]);
                newTransaction.DateAdded = Convert.ToDateTime(eventTransaction["DateAdded"]);
                newTransaction.Description =eventTransaction["Description"];
                newTransaction.TransactionCategoryId = transactionCategoryId;
                db.EventTransactions.Add(newTransaction);
                db.SaveChanges();
            }

            return RedirectToAction("Index", new { eventId = eventId });
        }

        // GET: EventTransactions/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventTransaction eventTransaction = db.EventTransactions.Find(id);
            if (eventTransaction == null)
            {
                return HttpNotFound();
            }
            ViewBag.TransactionCategoryId = new SelectList(db.TransactionCategories, "Id", "Category");
            return View(eventTransaction);
        }

        // POST: EventTransactions/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,EventId,Amount,FHICredit,Description,DateAdded")] EventTransaction eventTransaction)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventTransaction).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.TransactionCategoryId = new SelectList(db.TransactionCategories, "Id", "Category");
            return View(eventTransaction);
        }

        // GET: EventTransactions/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventTransaction eventTransaction = db.EventTransactions.Find(id);
            if (eventTransaction == null)
            {
                return HttpNotFound();
            }
            return View(eventTransaction);
        }

        // POST: EventTransactions/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventTransaction eventTransaction = db.EventTransactions.Find(id);
            db.EventTransactions.Remove(eventTransaction);
            db.SaveChanges();
            return RedirectToAction("Index", new { eventId = eventTransaction.EventId });
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
