using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using Sunodia.ClassManagement.Models;
using System.Web.Mvc;

namespace Sunodia.ClassManagement.Models
{
    public class PeopleGroupViewModel
    {
        [Key]
        public int PersonId { get; set; }
        public int? NewGroupId { get; set; }
        public Person Person { get; set; }
        public IEnumerable<SelectListItem> AllGroups { get; set; }
    }


}