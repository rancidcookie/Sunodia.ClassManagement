using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sunodia.ClassManagement.Models
{
    [MetadataType(typeof(ClassMetaData))]
    public partial class Event
    {

    }

    public class ClassMetaData
    {
        [DisplayName("Course")]
        public string Cours { get; set; }
        [DisplayName("Nick Name")]
        public string NickName { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd - MMM - yyyy}")]
        [DisplayName("Registration Date")]
        public DateTime RegistrationDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd - MMM - yyyy}")]
        [DisplayName("Course Date")]
        public DateTime CourseDate { get; set; }

        [DisplayName("Start Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [DisplayName("Type")]
        public int CourseType { get; set; }


        [DisplayName("Material Cost")]
        public Nullable<decimal> MaterialCost { get; set; }
        [DisplayName("Course Format")]
        public Nullable<int> CourseFormatId { get; set; }
        [DisplayName("Book Cost")]
        public Nullable<decimal> BookCost { get; set; }
        [DisplayName("Book")]
        public Nullable<int> BookId { get; set; }
        [DisplayName("Registration Cost")]
        public Nullable<decimal> RegistrationCost { get; set; }

        [DisplayName("Facilitator")]
        public Nullable<int> FacilitatorId { get; set; }
        [DisplayName("Frequency")]
        public Nullable<int> FrequencyId { get; set; }
    }
}