using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Sunodia.ClassManagement.Utility.Eventbrite.Models
{
    [DataContract]
    public class Pagination
    {
        [DataMember]
        public int object_count { get; set; }
        [DataMember]
        public int page_number { get; set; }
        [DataMember]
        public int page_size { get; set; }
        [DataMember]
        public int page_count { get; set; }
    }

    [DataContract]
    public class EventTime
    {
        [DataMember]
        string timezone { get; set; }
        [DataMember]
        string local { get; set; }

        [DataMember]
        string utc { get; set; }
        public DateTime ToDate()
        {
            return Convert.ToDateTime(local);

        }
    }


}
