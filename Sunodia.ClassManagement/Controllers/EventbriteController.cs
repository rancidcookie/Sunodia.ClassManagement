using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

using Sunodia.ClassManagement.Models;
using mEvent = Sunodia.ClassManagement.Models.Event;
using ebEvent = Sunodia.ClassManagement.Utility.Eventbrite.Models.Event;

using Sunodia.ClassManagement.Utility.Eventbrite;
using Sunodia.ClassManagement.Utility.Eventbrite.Models;

namespace Sunodia.ClassManagement.Controllers
{
    public class EventbriteController : Controller
    {
        // GET: Eventbrite
        public ActionResult Index(int? eventId)
        {
            List<ebEvent> events;
            var context = new EBContext();
            events = new List<ebEvent>();

            if (eventId != null)
            {
                ViewBag.EventId = eventId;
                sunodiaEntities db = new sunodiaEntities();
                var tmpEvent = db.Events.Where(x => x.Id == eventId).First();
                ViewBag.EventName = tmpEvent.NickName;

                //Check if there is already an EB event linked
                if (tmpEvent.EventbriteEvents.Count() > 0)
                {
                    var tmpEB = context.GetEvent(tmpEvent.EventbriteEvents.First().EventbriteEventId);
                    events.Add(tmpEB);
                    ViewBag.AlreadyLinked = true;
                }
                else
                {
                    events = context.GetEvents();
                }
            }

            

            return View(events.ToList());
        }

        // GET: Eventbrite/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Eventbrite/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Eventbrite/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Eventbrite/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Eventbrite/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult LinkEvent(string ebEventId, int eventId, bool linkt)
        {
            return Link(ebEventId, eventId, linkt);
        }

        // POST: Eventbrite/Delete/5
        [HttpPost]
        public ActionResult LinkEvent(FormCollection collection)
        {
            try
            {
                //Load from collection
                var eventId = Convert.ToInt32(collection["Event.Id"]);
                var ebEventId = collection["EventbriteId"];
                var alreadyLinkt = collection["AlreadyLinked"].ToLower();

                //Get the current event from DB
                sunodiaEntities db = new sunodiaEntities();
                var tmpEvent = db.Events.Where(x => x.Id == eventId).First();
                var existingEbs = tmpEvent.EventbriteEvents;

                if(alreadyLinkt == "true")
                {//This means you're unlinking
                    db.Entry(existingEbs.First()).State = System.Data.Entity.EntityState.Deleted;

                }
                else
                {//Creating a new link
                    var ebContext = new EBContext();
                    var tmpEB = ebContext.GetEvent(ebEventId);

                    if (existingEbs != null)
                    {
                        if (existingEbs.Count() > 0)
                        {
                            var existingEB = existingEbs.First();
                            existingEB.EventbriteEventId = tmpEB.id;
                            existingEB.EventbriteEventURL = tmpEB.url;

                        }
                        else
                        {
                            var newEBEvent = new EventbriteEvent()
                            {
                                EventbriteEventId = ebEventId,
                                EventId = eventId,
                                EventbriteEventURL = tmpEB.url
                            };
                            db.EventbriteEvents.Add(newEBEvent);
                        }
                    }
                }
                db.SaveChanges();
                return RedirectToAction("Index", new
                {
                    eventId = eventId,
                });
            }
            catch(Exception ex)
            {
                return View();
            }
        }
        public ActionResult UnLinkEvent(string ebEventId, int eventId)
        {
            return RedirectToAction("LinkEvent", new
            {
                ebEventId = ebEventId,
                eventId = eventId,
                linkt = true
            });
            //return Link(ebEventId, eventId, false);
        }
        private ActionResult Link(string ebEventId, int eventId, bool link)
        {
            LinkEventsViewModel retVal = new LinkEventsViewModel();
            sunodiaEntities db = new sunodiaEntities();
            ViewBag.AlreadyLinked = link;
            retVal.Event = db.Events.Where(x => x.Id == eventId).First();

            var context = new EBContext();
            var ebEvent = context.GetEvent(ebEventId);
            var ebVenue = context.GetVenue(ebEvent.venue_id);
            retVal.EventbriteId = ebEventId;
            retVal.EventbriteName = ebEvent.name.text;
            var tmpDates = string.Format("{0} - {1}", ebEvent.start.local, ebEvent.end.local);
            retVal.EventbriteDates = tmpDates;
            retVal.EventbriteVenue = ebVenue.name;

            return View(retVal);
        }
        // POST: Eventbrite/Delete/5
        [HttpPost]
        public ActionResult UnLinkEvent(FormCollection collection)
        {
            try
            {
                //Need to add the eventbriteid to the event
                sunodiaEntities db = new sunodiaEntities();
                var eventId = Convert.ToInt32(collection["Event.Id"]);
                var ebEventId = collection["EventbriteId"];

                var tmpEvent = db.Events.Where(x => x.Id == eventId).First();
                var existingEbs = tmpEvent.EventbriteEvents;
                var ebContext = new EBContext();
                var tmpEB = ebContext.GetEvent(ebEventId);

                if (existingEbs != null)
                {
                    if (existingEbs.Count() > 0)
                    {
                        var existingEB = existingEbs.First();
                        existingEB.EventbriteEventId = tmpEB.id;
                        existingEB.EventbriteEventURL = tmpEB.url;

                    }
                    else
                    {
                        var newEBEvent = new EventbriteEvent()
                        {
                            EventbriteEventId = ebEventId,
                            EventId = eventId,
                            EventbriteEventURL = tmpEB.url
                        };
                        existingEbs = new List<EventbriteEvent>();
                        existingEbs.Add(newEBEvent);
                    }
                    db.SaveChanges();
                }

                return RedirectToAction("Index", new
                {
                    eventId = eventId,
                });
            }
            catch
            {
                return View();
            }
        }

    }
}
