using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
    
using System.Web;
using System.Web.Mvc;

using Sunodia.ClassManagement.Models;
using Sunodia.ClassManagement.Utility.Email;

namespace Sunodia.ClassManagement.Controllers
{
    public class EventStudentsController : Controller
    {
        private fhiEntities db = new fhiEntities();

        // GET: EventStudents
        public ActionResult Index(int? eventId)
        {
            var eventStudents = db.EventStudents.Include(e => e.Event).Include(e => e.Person).Where(x => x.EventId == eventId);

            var parentEvent = db.Events.Where(x => x.Id == eventId).First();
            if (parentEvent != null)
            {
                ViewBag.EventId = eventId;
                ViewBag.EventNickName = parentEvent.NickName;
            }
            return View(eventStudents.ToList());
        }

        // GET: EventStudents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventStudent eventStudent = db.EventStudents.Find(id);
            if (eventStudent == null)
            {
                return HttpNotFound();
            }
            return View(eventStudent);
        }

        // GET: EventStudents/Create
        public ActionResult Create()
        {
            ViewBag.EventId = new SelectList(db.Events, "Id", "Description");
            ViewBag.StudentId = new SelectList(db.People, "Id", "LastName");
            return View();
        }

        // POST: EventStudents/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,StudentId,EventId,DateAdded")] EventStudent eventStudent)
        {
            if (ModelState.IsValid)
            {
                db.EventStudents.Add(eventStudent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.EventId = new SelectList(db.Events, "Id", "Description", eventStudent.EventId);
            ViewBag.StudentId = new SelectList(db.People, "Id", "LastName", eventStudent.StudentId);
            return View(eventStudent);
        }

        public ActionResult Add(int? eventId, int? studentId, string firstNameFilter, string lastNameFilter)
        {
            var eventStudent = new EventStudent() { StudentId = (int)studentId, EventId = (int)eventId , DateAdded = DateTime.Now};
            db.EventStudents.Add(eventStudent);
            db.SaveChanges();

            return RedirectToAction("Search", new
            {
                firstNameFilter = firstNameFilter,
                lastNameFilter = lastNameFilter,
                EventId = eventId
            });


        }

        // GET: EventStudents/Edit/5

        public ActionResult Search(string firstNameFilter, string lastNameFilter, int? EventId)
        {
            var students = db.People.Where(x => x.PersonGroups.Any(y => y.Group.GroupName == "Student"));
            var myEvent = db.Events.Where(x => x.Id == EventId).First();

            if (!string.IsNullOrEmpty(firstNameFilter))
                students = students.Where(x => x.FirstName.Contains(firstNameFilter));

            if (!string.IsNullOrEmpty(lastNameFilter))
                students = students.Where(x => x.LastName.Contains(lastNameFilter));


            ViewBag.EventId = EventId;
            ViewBag.EventNickName = myEvent.NickName;
            return View(students);
        }

        [HttpPost]
        public ActionResult Search(FormCollection collection)
        {

            return RedirectToAction("Search", new
            {
                firstNameFilter = collection["firstNameFilter"],
                lastNameFilter = collection["lastNameFilter"],
                EventId = collection["eventId"]
            });
        }


        // POST: EventStudents/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,StudentId,EventId,DateAdded")] EventStudent eventStudent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eventStudent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.EventId = new SelectList(db.Events, "Id", "Description", eventStudent.EventId);
            ViewBag.StudentId = new SelectList(db.People, "Id", "LastName", eventStudent.StudentId);
            return View(eventStudent);
        }

        // GET: EventStudents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EventStudent eventStudent = db.EventStudents.Find(id);
            var eventId = eventStudent.EventId;

            if (eventStudent == null)
            {
                return HttpNotFound();
            }
            else
            {
                db.EventStudents.Remove(eventStudent);
                db.SaveChanges();
                return RedirectToAction("Search", new
                {
                    firstNameFilter = "",
                    lastNameFilter = "",
                    EventId = eventId
                });
            }
        }

        public ActionResult DeleteCost(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Delete the StudentTrx Record
            EventTransactionStudent eventTrxStudent = db.EventTransactionStudents.Where(x => x.EventTransactionId == id).First();
            var myStudent = eventTrxStudent.StudentId;

            db.EventTransactionStudents.Remove(eventTrxStudent);

            //Delete the trx
            EventTransaction eventTrx = db.EventTransactions.Where(x => x.Id == id).First();
            var myEventId = eventTrx.EventId;
            db.EventTransactions.Remove(eventTrx);

            db.SaveChanges();
                return RedirectToAction("Cost", new
                {
                    eventId = myEventId,
                    studentId = myStudent,
                });
        }


        public async Task<ActionResult> Email(int? studentId, int? eventId, string amountDue)
        {
            var email = db.People.Where(x => x.Id == studentId).First().Email;
            var eventDue = db.Events.Where(x => x.Id == eventId).First().NickName;
            var response = "";

            try
            {
                MailjetEmail emailer = new MailjetEmail();
                emailer.SendEmail(amountDue, eventDue, email);
            }
            catch(Exception ex)
            {
                response = ex.Message;

            }


            return RedirectToAction("Edit", "Events", new { id=eventId });
        }

            public ActionResult Cost(int? eventId, int? studentId)
        {
            var eventTrx = new StudentCostViewModel();
            eventTrx.Student = db.People.Where(s => s.Id == studentId).FirstOrDefault();
            eventTrx.Event = db.Events.Where(e => e.Id == eventId).FirstOrDefault();
            eventTrx.StudentTransactions = db.vwEventTransactions.Where(x => x.EventId == eventId && x.StudentId == studentId).ToList();
            ViewBag.EventId = eventId;


            //eventTrx.RegTypes = new SelectList(db.RegistrationTypes, "Id", "Description");
            //eventTrx.RegTypes.Default("NA", "");


            eventTrx.RegTypes = db.RegistrationTypes
              .Select(r => new SelectListItem
              {
                  Value = r.Id.ToString(),
                  Text = r.Description
              });

            eventTrx.EventDescs = db.EventCost2Student.Where(x=>x.EventId == eventId)
              .Select(c => new SelectListItem
              {
                  Value = c.CostDescription,
                  Text = c.CostDescription
              });

            eventTrx.PaymentTypes = db.PaymentMethods
              .Select(r => new SelectListItem
              {
                  Value = r.Id.ToString(),
                  Text = r.PaymentMethod1
              });


            //eventTrx.RegTypes = db.RegistrationTypes
            //  .Select(c => new SelectListItem
            //  {
            //      Value = c.Id.ToString(),
            //      Text = c.Description
            //  });
            //eventTrx.RegTypes.ToList().Add(new SelectListItem { Value = null, Text = "N/A" });

            return View(eventTrx);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Cost(FormCollection collection)
            //public ActionResult Cost(string description)
        {
            var eventId = 0;
            var studentId = 0;
            if (ModelState.IsValid)
            {
                var amountArray = collection["Amount"].Split(',');

                var amountDue = amountArray[0];
                var amountPaid = amountArray[1];
                eventId = Convert.ToInt32(collection["EventId"]);
                studentId = Convert.ToInt32(collection["Student.Id"]);
                var desc = collection["Description"];
                var regTypeId = collection["RegistrationTypeId"];
                var paymentMethodId = collection["PaymentMethodId"];

                if (!string.IsNullOrEmpty(amountDue))
                    AddTrx(eventId, studentId, desc, Convert.ToDecimal(amountDue), true, regTypeId, paymentMethodId);

                if (!string.IsNullOrEmpty(amountPaid))
                    AddTrx(eventId, studentId, desc, Convert.ToDecimal(amountPaid), false, regTypeId, paymentMethodId);
                     


                db.SaveChanges();
            }
            return RedirectToAction("Cost", new
            {
                eventId = eventId,
                studentId = studentId
            });
        }

        private void AddTrx(int eventId, int studentId, string desc, decimal amount, bool isCredit, string regTypeId, string payemntMethodId)
        {
            int? myRegId = null;
            int? myPaymentMethodId = null;

            if (!string.IsNullOrEmpty(regTypeId))
                myRegId = Convert.ToInt32(regTypeId);


            if (!string.IsNullOrEmpty(payemntMethodId))
                myPaymentMethodId = Convert.ToInt32(payemntMethodId);

            var newTransaction = new EventTransaction()
            {
                Amount = Convert.ToDecimal(amount),
                EventId = Convert.ToInt32(eventId),
                DateAdded = DateTime.Now,
                Description = desc,
                FHICredit = isCredit,
                PaymentMethodId = myPaymentMethodId,
                EventTransactionStudents = new List<EventTransactionStudent>()
                    {
                         new EventTransactionStudent()
                        {
                            StudentId = studentId,
                            RegistrationTypeId = myRegId
                        }
                    }

            };


            db.EventTransactions.Add(newTransaction);
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
