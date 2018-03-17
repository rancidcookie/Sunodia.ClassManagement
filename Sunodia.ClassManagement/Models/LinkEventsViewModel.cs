using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace Sunodia.ClassManagement.Models
{
    public class LinkEventsViewModel
    {
        //[Key]
        //public int EventId { get; set; }
        public Event Event { get; set; }
        public string EventbriteId { get; set; }
        public string EventbriteName { get; set; }
        public string EventbriteDates{ get; set; }
        public string EventbriteVenue { get; set; }

    }
}
