using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Sunodia.ClassManagement.Models;
using Sunodia.ClassManagement.Utility.Eventbrite;
using Sunodia.ClassManagement.Utility.Eventbrite.Models;

using eEvent = Sunodia.ClassManagement.Utility.Eventbrite.Models.Event;
using sEvent = Sunodia.ClassManagement.Models.Event;

namespace Sunodia.ClassManagement.Controllers
{
    public class EventsController : Controller
    {
        private fhiEntities db = new fhiEntities();

        // GET: Classes
        public ActionResult Index()
        {
            var classes = db.Events.Include(x => x.CourseFormat).Include(y => y.Cours).Where(x=>x.Active);
            return View(classes.ToList());
        }

        // GET: Classes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sEvent @class = db.Events.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }
            return View(@class);
        }

        // GET: Classes/Create
        public ActionResult Create()
        {
            ViewBag.CourseFormatId = new SelectList(db.CourseFormats, "Id", "Format","");
            ViewBag.FrequencyId = new SelectList(db.Frequencies, "Id", "Frequency1", "");
            var SelectCourse = new SelectList(db.Courses, "Id", "CourseName");
            SelectCourse.Default("Select Course","");
            ViewBag.CourseId = SelectCourse;
            
            return View();
        }

        // POST: Classes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Exclude = "Id")] sEvent @class)
        {
            if (ModelState.IsValid)
            {
                @class.Active = true;
                db.Events.Add(@class);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            //ViewBag.CourseFormatId = new SelectList(db.CourseFormats, "Id", "Format", @class.CourseFormatId);
            //ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", @class.);
            return View(@class);
        }

        // GET: Classes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sEvent @class = db.Events.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }

            //var facils = db.People.Where(x => x.PersonGroups.Any(y => y.Group.GroupName == "Facilitators"));
            var facils = db.vwGroups.Where(x => x.GroupName == "facilitator");

            ViewBag.CourseFormatId = new SelectList(db.CourseFormats, "Id", "Format", @class.CourseFormatId);
            ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", @class.CourseId);

            //ViewBag.FacilitatorId = new SelectList(facils,"Id","LastName",@class.FacilitatorId);
            ViewBag.FacilitatorId = new SelectList(facils, "Id", "FullName", @class.FacilitatorId);
            ViewBag.FrequencyId = new SelectList(db.Frequencies, "Id", "Frequency1", @class.FrequencyId);
            ViewBag.FacCount = facils.Count();
            return View(@class);
        }


        // POST: Classes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CourseId,StartDate,EndDate,FrequencyId,CourseType,NickName,FacilitatorId")] sEvent @class)
        {
            if (ModelState.IsValid)
            {
                @class.Active = true;
                db.Entry(@class).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            //ViewBag.CourseFormatId = new SelectList(db.CourseFormats, "Id", "Format", @class.CourseFormatId);
            //ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", @class.CourseId);
            return View(@class);
        }

        // GET: Classes/Edit/5
        public ActionResult Costs(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sEvent @class = db.Events.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }

            //ViewBag.CostDescriptions = new SelectList(db.StudentCosts, "Id", "Description", @class.C);
            
            return View(@class);
        }

        // POST: Classes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Costs([Bind(Include = "EventId,Cost,CostDescription,Required")] EventCost2Student @costs)
        {
            if (ModelState.IsValid)
            {
                db.EventCost2Student.Add(@costs);
                db.SaveChanges();
            }
            //ViewBag.CourseFormatId = new SelectList(db.CourseFormats, "Id", "Format", @class.CourseFormatId);
            //ViewBag.CourseId = new SelectList(db.Courses, "Id", "CourseName", @class.CourseId);
            return RedirectToAction("Costs", @costs.EventId);
        }

        public ActionResult CostDelete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventCost2Student eventcostStudent = db.EventCost2Student.Find(id);
            var eventId = eventcostStudent.EventId;

            if (eventcostStudent == null)
            {
                return HttpNotFound();
            }
            else
            {
                db.EventCost2Student.Remove(eventcostStudent);
                db.SaveChanges();
                return RedirectToAction("Costs",  new
                {
                    id = eventId
                });
            }
        }

        // GET: Classes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            sEvent @class = db.Events.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }
            return View(@class);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            sEvent myClass = db.Events.Find(id);
            myClass.Active = false;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult ImportAsk(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var eContext = new Context();

            sEvent @class = db.Events.Find(id);
            if (@class == null)
            {
                return HttpNotFound();
            }
            return View(@class);
        }

        // POST: Classes/Delete/5
        [HttpPost, ActionName("Import")]
        [ValidateAntiForgeryToken]
        public ActionResult ImportConfirmed(int id)
        {
            //Event myClass = db.Events.Find(id);
            //myClass.Active = false;
            //db.SaveChanges();
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
