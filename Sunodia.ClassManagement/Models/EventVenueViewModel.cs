
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Sunodia.ClassManagement.Models;

namespace Sunodia.ClassManagement.Models
{
    public class EventVenueViewModel
    {
        [Key]
        public int EventId { get; set; }
        public int? NewVenueId { get; set; }
        public Event Event { get; set; }
        public IEnumerable<SelectListItem> AllVenues { get; set; }
    }
}


