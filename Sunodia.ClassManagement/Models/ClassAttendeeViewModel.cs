using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunodia.ClassManagement.Models
{
    public class ClassTransactionViewModel
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }
        public List<StudentTransactionViewModel> StudentTransactions { get; set; }
        public List<MiscTransactionViewModel> MiscTransactions { get; set; }
    }


    public class StudentTransactionViewModel
    {
        [Key]
        public int TransactionId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RegistrationType { get; set; }
        public Decimal Paid { get; set; }
        public bool Attending { get; set; }
        public string PaymentMethod { get; set; }
    }

    public class MiscTransactionViewModel
    {
        [Key]
        public int TransactionId { get; set; }
        public string TransactionType { get; set; }
        public DateTime? TransactionDate { get; set; }
        public decimal? Amount { get; set; }
        public string PaymentMethod { get; set; }
    }
}



//LastName FirstNameCoursePaidAttendingPayment MethodDescription