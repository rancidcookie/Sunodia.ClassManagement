using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Sunodia.ClassManagement.Models;

namespace Sunodia.ClassManagement.Controllers
{
    public class PersonGroupsController : Controller
    {
        private fhiEntities db = new fhiEntities();
        // GET: PersonGroups
        public ActionResult Index(int? PersonId)
        {
            var model = new PeopleGroupViewModel();
            model.Person = db.People.Where(x => x.Id == PersonId).First();
            model.PersonId = PersonId??0;

            var groups = db.Groups
             .Select(x =>
                     new SelectListItem
                     {
                         Value = x.Id.ToString(),
                         Text = x.GroupName
                     });
            model.AllGroups = new SelectList(groups, "Value", "Text");
            return View(model);
        }

        // GET: PersonGroups/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PersonGroups/Create
        public ActionResult Add(int? PersonId, int? GroupId)
        {
            return View();
        }

        // POST: PersonGroups/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                var groupId = Convert.ToInt32(collection["GroupId"]);
                var personId = Convert.ToInt32(collection["PersonId"]);
                var newPersonGroup = new PersonGroup() { PersonId = personId, GroupId = groupId };
                db.PersonGroups.Add(newPersonGroup);
                db.SaveChanges();
                return RedirectToAction("Index",new { PersonId = personId });
            }
            catch
            {
                return View();
            }
        }

        // GET: PersonGroups/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PersonGroups/Edit/5
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

        // GET: PersonGroups/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        // POST: PersonGroups/Delete/5
        public ActionResult Delete(int id)
        {
            try
            {
                //var newPersonGroup = new PersonGroup() { PersonId = personId, GroupId = groupId };
                var tmpRec = db.PersonGroups.Find(id);
                var personId = tmpRec.PersonId;
                db.PersonGroups.Remove(tmpRec);
                db.SaveChanges();
                return RedirectToAction("Index", new { PersonId = personId });
            }
            catch
            {
                return View();
            }
        }
    }
}
