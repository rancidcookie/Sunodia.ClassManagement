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
    public class ClassAttendeesController : Controller
    {
        private fhiEntities db = new fhiEntities();

        // GET: ClassAttendees
        public ActionResult Index(int id)
        {
            var transactions = db.GetTransactions(id);
            return View(transactions);
        }

        // GET: ClassAttendees/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassAttendee classAttendee = db.ClassAttendees.Find(id);
            if (classAttendee == null)
            {
                return HttpNotFound();
            }
            return View(classAttendee);
        }

        // GET: ClassAttendees/Create
        public ActionResult Create(int? id)
        {
            var tmpList = new SelectList(db.Events, "Id", "CourseId");
            
            ViewBag.ClassId = tmpList;
            ViewBag.ClassId2 = id;
            var tmpClass = db.Events.Where(x => x.Id == id).First();
            ViewBag.ClassDesc = tmpClass.NickName;

            ViewBag.PayerId = db.GetPeopleList(null);
            ViewBag.PaymentTypeId = new SelectList(db.PaymentMethods, "Id", "PaymentMethod1");
            ViewBag.PersonId = db.GetPeopleList(null);
            ViewBag.RegistrationTypeId = new SelectList(db.RegistrationTypes, "Id", "Description");
            return View();
        }

        // GET: ClassAttendees/Create
        public ActionResult CreateMisc(int? id)
        {
            var tmpList = new SelectList(db.Events, "Id", "CourseId");

            ViewBag.ClassId = tmpList;
            ViewBag.ClassId2 = id;
            ViewBag.ClassDesc = db.Events.Where(x => x.Id == id).First().Description;

            //ViewBag.PayerId = db.GetPeopleList(null);
            ViewBag.QBAccounts = new SelectList(db.QBAccounts, "Id", "Description");
            ViewBag.PaymentTypeId = new SelectList(db.PaymentMethods, "Id", "PaymentMethod1");

            return View();
        }
        // POST: ClassAttendees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,ClassId,PersonId,PayerId,RegistrationPaid,BookPaid,StudyGuidPaid,RegistrationTypeId,Attending,QBDate,PaymentTypeId")] ClassAttendee classAttendee)
        public ActionResult Create([Bind(Exclude ="Id")] ClassAttendee classAttendee)
        {
            if (ModelState.IsValid)
            {
                db.ClassAttendees.Add(classAttendee);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = classAttendee.ClassId });
            }

            ViewBag.ClassId = new SelectList(db.Events, "Id", "CourseId", classAttendee.ClassId);
            ViewBag.PayerId = db.GetPeopleList(classAttendee.PayerId);
            ViewBag.PaymentTypeId = new SelectList(db.PaymentMethods, "Id", "PaymentMethod1", classAttendee.PaymentTypeId);
            return View(classAttendee);
        }

        // POST: ClassAttendees/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        //public ActionResult Create([Bind(Include = "Id,ClassId,PersonId,PayerId,RegistrationPaid,BookPaid,StudyGuidPaid,RegistrationTypeId,Attending,QBDate,PaymentTypeId")] ClassAttendee classAttendee)
        public ActionResult CreateMisc([Bind(Exclude = "Id")] MiscTransaction miscTransaction)
        {
            if (ModelState.IsValid)
            {
                db.MiscTransactions.Add(miscTransaction);
                db.SaveChanges();
                return RedirectToAction("Index", new { id = miscTransaction.ClassId });
            }

            var tmpList = new SelectList(db.Events, "Id", "CourseId");

            ViewBag.ClassId = tmpList;
            ViewBag.ClassId2 = miscTransaction.ClassId;
            ViewBag.ClassDesc = db.Events.Where(x => x.Id == miscTransaction.ClassId).First().NickName;

            //ViewBag.PayerId = db.GetPeopleList(null);
            ViewBag.QBAccounts = new SelectList(db.QBAccounts, "Id", "Description");
            ViewBag.PaymentTypeId = new SelectList(db.PaymentMethods, "Id", "PaymentMethod1");
            return View(miscTransaction);
        }

        // GET: ClassAttendees/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassAttendee classAttendee = db.ClassAttendees.Find(id);
            if (classAttendee == null)
            {
                return HttpNotFound();
            }
            ViewBag.ClassId = new SelectList(db.Events, "Id", "CourseId", classAttendee.ClassId);

            ViewBag.PaymentTypeId = new SelectList(db.PaymentMethods, "Id", "PaymentMethod1", classAttendee.PaymentTypeId);
            ViewBag.PersonId = db.GetPeopleList(classAttendee.PersonId);
            ViewBag.PayerId = db.GetPeopleList(classAttendee.PayerId);
            ViewBag.RegistrationTypeId = new SelectList(db.RegistrationTypes, "Id", "Description", classAttendee.RegistrationTypeId);
            return View(classAttendee);
        }

        // POST: ClassAttendees/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,ClassId,PersonId,PayerId,Paid,RegistrationTypeId,Attending,QBDate,PaymentTypeId")] ClassAttendee classAttendee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(classAttendee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index",new { Id = classAttendee.ClassId });
            }
            ViewBag.ClassId = new SelectList(db.Events, "Id", "CourseId", classAttendee.ClassId);
            ViewBag.PaymentTypeId = new SelectList(db.PaymentMethods, "Id", "PaymentMethod1", classAttendee.PaymentTypeId);
            ViewBag.PersonId = db.GetPeopleList(classAttendee.PersonId);
            ViewBag.PayerId = db.GetPeopleList(classAttendee.PayerId);
            ViewBag.RegistrationTypeId = new SelectList(db.RegistrationTypes, "Id", "Description", classAttendee.RegistrationTypeId);
            return View(classAttendee);
        }

        // GET: ClassAttendees/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ClassAttendee classAttendee = db.ClassAttendees.Find(id);
            if (classAttendee == null)
            {
                return HttpNotFound();
            }
            return View(classAttendee);
        }

        // POST: ClassAttendees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ClassAttendee classAttendee = db.ClassAttendees.Find(id);
            db.ClassAttendees.Remove(classAttendee);
            db.SaveChanges();
            return RedirectToAction("Index", new { Id = classAttendee.ClassId });
        }
        public ActionResult PickClass()
        {
            PickClassViewModel vm = new PickClassViewModel();
            vm.Classes = new SelectList(db.Events, "Id", "CourseId");

            return View(vm);

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
