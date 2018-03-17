using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Sunodia.ClassManagement.Utility.Eventbrite.Models
{
    [DataContract]
    public class Events
    {
        [DataMember]
        public Pagination pagination { get; set; }
        [DataMember]
        public List<Event> events { get; set; }
    }
    [DataContract]
    public class Event
    {
        [DataMember]
        public Name name { get; set; }
        [DataMember]
        public string id { get; set; }
        [DataMember]
        public string title { get; set; }
        [DataMember]
        public Description description { get; set; }
        [DataMember]
        public EventTime start { get; set; }
        [DataMember]
        public EventTime end { get; set; }
        [DataMember]
        public string created { get; set; }
        [DataMember]
        public string changed { get; set; }
        [DataMember]
        public string status { get; set; }

        [DataMember]
        public string venue_id { get; set; }
        [DataMember]
        public string format_id { get; set; }
        [DataMember]
        public string url { get; set; }
        //public Dictionary<long, Ticket> Tickets = new Dictionary<long, Ticket>();

        //private List<Attendee> attendees;
        //public List<Attendee> Attendees
        //{
        //    get
        //    {
        //        if (this.attendees == null)
        //        {
        //            this.attendees = new List<Attendee>();
        //            this.attendees.AddRange(new EventAttendeesRequest(this.Id, Context).GetResponse());
        //        }
        //        return attendees;
        //    }
        //}

    }
    [DataContract]
    public class Description
    {
        [DataMember]
        public string text { get; set; }
    }

    [DataContract]
    public class Name
    {
        [DataMember]
        public string text { get; set; }
        [DataMember]
        public string html { get; set; }
    }
}
