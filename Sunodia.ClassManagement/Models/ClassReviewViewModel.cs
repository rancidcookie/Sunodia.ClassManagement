using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunodia.ClassManagement.Models
{
    public class ClassReviewViewModel
    {
        [Key]
        public string ClassName { get; set; }
        public int TotalStudents { get; set; }
        public int TotalRegistered { get; set; }
        public decimal TotalPaid { get; set; }
        public List<StudentBreakDown> StudentAccounts { get; set; }
        public List<MiscTotals> Miscellaneous { get; set; }
    }

    public class StudentBreakDown
    {
        [Key]
        public string PaymentType { get; set; }
        public decimal Total { get; set; }
    }

    public class MiscTotals
    {
        [Key]
        public string Account { get; set; }
        public string QBAccount { get; set; }
        public decimal Total { get; set; }
    }

    [MetadataType(typeof(vwMiscTotalMetaData))]
    public partial class vwMiscTotal
    { }

    public partial class vwMiscTotalMetaData
    {
        [Key]
        public int ClassId { get; set; }
        //public string Description { get; set; }
        //public string PaymentMethod { get; set; }
        //public Nullable<decimal> TotalPaid { get; set; }
    }

    [MetadataType(typeof(vwRegistrationTotalMetaData))]
    public partial class vwRegistrationTotal
    { }

    public partial class vwRegistrationTotalMetaData
    {
        [Key]
        public int ClassId { get; set; }
    }

    [MetadataType(typeof(vwStudentTotalMetaData))]
    public partial class vwStudentTotal
    { }

    public partial class vwStudentTotalMetaData
    {
        [Key]
        public int classid { get; set; }
    }
}