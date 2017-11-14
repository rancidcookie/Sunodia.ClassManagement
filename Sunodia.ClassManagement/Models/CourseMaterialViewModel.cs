using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
namespace Sunodia.ClassManagement.Models
{
    public class CourseMaterialViewModel
    {
        [Key]
        public int CourseId { get; set; }
        public Cours Course { get; set; }
        public List<CourseMaterial> Materials { get; set; }
        public IEnumerable<SelectListItem> AllVendors { get; set; }
    }
}

