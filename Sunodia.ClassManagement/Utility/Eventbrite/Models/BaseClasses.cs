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
        private string _local = "";
        [DataMember]
        string timezone { get; set; }
        [DataMember]
        public string local
        {
            get
            {
                return _local;
            }
            set
            {
                var newValue = value;
                DateTime newDate;
                if (DateTime.TryParse(newValue, out newDate))
                    newValue = newDate.ToString();

                _local =  newValue;
            }
        }
        [DataMember]
        string utc { get; set; }
        public DateTime ToDate()
        {
            return Convert.ToDateTime(local);

        }

    }


}
