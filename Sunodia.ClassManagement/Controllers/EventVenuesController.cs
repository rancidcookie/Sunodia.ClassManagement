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
    public class EventVenuesController : Controller
    {
        private sunodiaEntities db = new sunodiaEntities();

        // GET: EventVenues
        public ActionResult Index(int? eventId)
        {
            var model = new EventVenueViewModel();
            model.Event = db.Events.Where(x => x.Id == eventId).First();
            model.EventId = eventId ?? 0;

            var venues = db.Venues
             .Select(x =>
                     new SelectListItem
                     {
                         Value = x.Id.ToString(),
                         Text = x.Name
                     });
            model.AllVenues = new SelectList(venues, "Value", "Text");
            return View(model);
        }

        // GET: EventVenues/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventVenue eventVenue = db.EventVenues.Find(id);
            if (eventVenue == null)
            {
                return HttpNotFound();
            }
            return View(eventVenue);
        }

        // GET: EventVenues/Create
        public ActionResult Create()
        {
            ViewBag.EventId = new SelectList(db.Events, "Id", "Description");
            ViewBag.VenueId = new SelectList(db.Venues, "Id", "Name");
            return View();
        }

        // POST: EventVenues/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,VenueId,EventId")] EventVenue eventVenue)
        {
            if (ModelState.IsValid)
            {
                db.EventVenues.Add(eventVenue);
                db.SaveChanges();
                return RedirectToAction("Index", new { eventId = eventVenue.EventId });
            }

            ViewBag.EventId = new SelectList(db.Events, "Id", "Description", eventVenue.EventId);
            ViewBag.VenueId = new SelectList(db.Venues, "Id", "Name", eventVenue.VenueId);
            return View(eventVenue);
        }

        public ActionResult Add(int? eventId, int? venueId)
        {
            var eventVenue = new EventVenue() { VenueId = (int)venueId, EventId = (int)eventId };
            db.EventVenues.Add(eventVenue);
            db.SaveChanges();

            return RedirectToAction("Index", new { eventId = eventId });

        }

        // GET: EventVenues/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventVenue eventVenue = db.EventVenues.Find(id);
            if (eventVenue == null)
            {
                return HttpNotFound();
            }
            ViewBag.EventId = new SelectList(db.Events, "Id", "Description", eventVenue.EventId);
            ViewBag.VenueId = new SelectList(db.Venues, "Id", "Name", eventVenue.VenueId);
            return View(eventVenue);
        }

        // POST: EventVenues/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VenueId,EventId")] EventVenue eventVenue)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventVenue).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventId = new SelectList(db.Events, "Id", "Description", eventVenue.EventId);
            ViewBag.VenueId = new SelectList(db.Venues, "Id", "Name", eventVenue.VenueId);
            return View(eventVenue);
        }

        // GET: EventVenues/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventVenue eventVenue = db.EventVenues.Find(id);
            var eventId = eventVenue.EventId;

            if (eventVenue == null)
            {
                return HttpNotFound();
            }
            else
            {
                db.EventVenues.Remove(eventVenue);
                db.SaveChanges();
                return RedirectToAction("Index", new { eventId = eventId });
            }
        }

        // POST: EventVenues/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EventVenue eventVenue = db.EventVenues.Find(id);
            db.EventVenues.Remove(eventVenue);
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
