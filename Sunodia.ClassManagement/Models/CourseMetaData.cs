using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace Sunodia.ClassManagement.Models
{
    [MetadataType(typeof(CourseMetaData))]
    public partial class Cours
    {

    }

    public class CourseMetaData
    {
        [DisplayName("Course Name")]
        public string CourseName { get; set; }
        [DisplayName("Course Number")]
        public string CourseNumber { get; set; }
        [DisplayName("Certiication Earned")]
        public string Cert { get; set; }
    }
}


