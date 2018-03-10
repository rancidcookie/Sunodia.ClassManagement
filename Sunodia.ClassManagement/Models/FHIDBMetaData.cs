using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sunodia.ClassManagement.Models
{

    public partial class fhiEntities
    {
        public SelectList GetPeopleList(object selectObject)
        {
            var qPeeps = this.People.Select(s => new SelectListItem
            {
                Value = s.Id.ToString(),
                Text = s.LastName + ", " + s.FirstName
            });
            //qPeeps.ToList().Add(new SelectListItem() { Value = "", Text = "" });
            var retVal = new SelectList(qPeeps,"Value","Text",selectObject);

            return retVal;

            //(db.PaymentMethods, "Id", "PaymentMethod1", classAttendee.PaymentTypeId);
        }

        public ClassTransactionViewModel GetTransactions(int classId)
        {
            var retVal = new ClassTransactionViewModel();
            //retVal.ClassId = classId;
            //var tmpClass = this.Events.Where(x => x.Id == classId);

            //var sTransactions = this.ClassAttendees.Include(c => c.).Include(c => c.Person).Include(c => c.PaymentMethod).Include(c => c.Person1).Include(c => c.RegistrationType).Where(x => x.ClassId == classId);
            //retVal.ClassName = tmpClass.First().Description;

            //retVal.StudentTransactions = new List<StudentTransactionViewModel>();
            //foreach(var transaction in sTransactions.ToList())
            //{
            //    var newX = new StudentTransactionViewModel();
            //   newX = new StudentTransactionViewModel()
            //    {
            //        Attending = transaction.Attending,
            //        Paid = transaction.Paid ?? 0,
            //        PaymentMethod = transaction.PaymentMethod.PaymentMethod1,
            //        RegistrationType = transaction.RegistrationType.Description,
            //        TransactionId = transaction.Id
            //    };
            //    if (transaction.Person1 != null)
            //    {
            //        newX.FirstName = transaction.Person1.FirstName;
            //        newX.LastName = transaction.Person1.LastName;
            //    }
            //    retVal.StudentTransactions.Add(newX);
            //}
            ////var mTransactions = this.MiscTransactions.Include(();
            //var mTransactions = this.MiscTransactions.Include(c => c.Event).Include(c => c.PaymentMethod).Include(c => c.QBAccount1).Where(c=>c.Event.Id == classId);
            //retVal.MiscTransactions = new List<MiscTransactionViewModel>();
            //foreach(var mTrans in mTransactions.ToList())
            //{
            //    var newMx = new MiscTransactionViewModel()
            //    {
            //        TransactionId = mTrans.Id,
            //        TransactionType = mTrans.QBAccount1.Description,
            //        TransactionDate = mTrans.TransactionDate,
            //        Amount = mTrans.Paid,
            //        PaymentMethod = mTrans.PaymentMethod1.PaymentMethod1
            //    };
            //    retVal.MiscTransactions.Add(newMx);

            //}
            

            return retVal;
        }

        public ClassReviewViewModel GetAnalysis(int classId)
        {
            var retVal = new ClassReviewViewModel();
            //var myClass = this.Events.Where(x => x.Id == classId);
            //var myStudentTotals = this.vwStudentTotals.Where(x => x.classid == classId);
            //var mySAccounts = this.vwRegistrationTotals.Where(x => x.ClassId == classId);
            ////var myMAccounts = this.vwMiscTotals.Where(x => x.ClassId == classId);
            //retVal.ClassName = myClass.First().NickName;
            //retVal.TotalPaid = myStudentTotals.First().TotalPaid??0;
            //retVal.TotalStudents = myStudentTotals.First().StudentCount??0;

            //retVal.StudentAccounts = new List<StudentBreakDown>();
            //foreach(var item in mySAccounts.ToList())
            //{
            //    var newSAccount = new StudentBreakDown()
            //    {
            //        PaymentType = item.Description,
            //        Total = item.Total ?? 0
            //    };
            //    retVal.StudentAccounts.Add(newSAccount);
            //}

            //retVal.Miscellaneous = new List<MiscTotals>();
            //foreach (var item in myMAccounts.ToList())
            //{
            //    var newMAccount = new MiscTotals()
            //    {
            //        Account = item.PaymentMethod,
            //        Total = item.TotalPaid ?? 0,
            //        //QBAccount = item.
            //    };
            //    retVal.Miscellaneous.Add(newMAccount);
            //}

            return retVal;
        }

        public System.Data.Entity.DbSet<ClassReviewViewModel> ClassReviewViewModels { get; set; }

        public System.Data.Entity.DbSet<PeopleGroupViewModel> PeopleGroupViewModels { get; set; }
    }
}