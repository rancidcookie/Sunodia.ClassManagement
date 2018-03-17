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

        [DisplayName("Start Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime StartDate { get; set; }

        [DisplayName("End Date")]
        [DisplayFormat(DataFormatString = "{0:MM/dd/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EndDate { get; set; }

        [DisplayName("Type")]
        public int CourseType { get; set; }

        [DisplayName("Facilitator")]
        public Nullable<int> FacilitatorId { get; set; }
        [DisplayName("Frequency")]
        public Nullable<int> FrequencyId { get; set; }
    }
}