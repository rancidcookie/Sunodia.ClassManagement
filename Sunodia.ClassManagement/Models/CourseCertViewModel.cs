using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sunodia.ClassManagement.Models;


namespace Sunodia.ClassManagement.Models
{
    public class CourseCertViewModel
    {
        [Key]
        public int CourseId { get; set; }
        public int? NewCertId { get; set; }
        public Cours Course { get; set; }
        public IEnumerable<SelectListItem> AllCerts { get; set; }
    }
}