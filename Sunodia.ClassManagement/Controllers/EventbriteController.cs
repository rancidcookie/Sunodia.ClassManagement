using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Sunodia.ClassManagement.Controllers
{
    public class EventbriteController : Controller
    {
        // GET: Eventbrite
        public ActionResult Index()
        {
            var url = @"https://www.eventbrite.com/oauth/authorize?response_type=code&client_id=YLQ5HNJ23GDTRMFI6K";
            var request = WebRequest.Create(url);
            var response = request.GetResponse();

            var token = response.GetResponseStream();


            return View();
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

        // GET: Eventbrite/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Eventbrite/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
