using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunodia.ClassManagement.Models
{
    [MetadataType(typeof(AttendeeMetaData))]
    public partial class ClassAttendee
    {    }

    public class AttendeeMetaData
    {
        [DisplayName("Class")]
        public int ClassId { get; set; }
        [DisplayName("Student")]
        public int PersonId { get; set; }
        [DisplayName("Payer")]
        public Nullable<int> PayerId { get; set; }
        [DisplayName("Paid")]
        public Nullable<decimal> Paid { get; set; }
        [DisplayName("Registration Type")]
        public Nullable<int> RegistrationTypeId { get; set; }
        [DisplayName("QB Date")]
        public Nullable<System.DateTime> QBDate { get; set; }
        [DisplayName("Payer Type")]
        public Nullable<int> PaymentTypeId { get; set; }
    }


}