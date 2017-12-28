using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Runtime.Serialization.Json;

using Sunodia.ClassManagement.Utility.Eventbrite.Models;

namespace Sunodia.ClassManagement.Utility.Eventbrite
{
    public class EBContext
    {
        //private string apiToken = "YCJS6WHRJYORXPXRQHNY";  //Dans
        private string apiToken = "QQ52LM4N3YJOLBDSXWJF";  //FHI
        
        //https://www.eventbriteapi.com/v3/users/me/owned_events?token=QQ52LM4N3YJOLBDSXWJF
        private string baseUrl = @"https://www.eventbriteapi.com/v3/";

        public EBContext()
        { }

        public EBContext(string apiToken)
        {
            this.apiToken = apiToken;
            //eContext = new EventbriteNET.EventbriteContext(apiToken);
        }

        public Orders GetOrders(string eventId)
        {
            var url = string.Format(@"{0}events/{1}/orders/?token={2}", baseUrl, eventId, apiToken);
            var request = WebRequest.Create(url);

            return GetResponse<Orders>(url);
        }
        public List<Event> GetEvents()
        {
            var aYearAgo = DateTime.Now.AddYears(-1);
            return GetEventsNewerThan(aYearAgo);
        }
        public List<Event> GetEventsNewerThan(DateTime thisDate)
        {
            //https://www.eventbriteapi.com/v3/users/me/owned_events?token=QQ52LM4N3YJOLBDSXWJF
            var url = string.Format(@"{0}users/me/owned_events/?order_by=start_desc&status=draft%2Clive%2Cstarted&token={1}", baseUrl, apiToken);
            var eventsObj = GetResponse<Events>(url);
            var allEvents = eventsObj.events;

            return allEvents.Where(x => x.start.ToDate() > thisDate).ToList();
        }

        private T GetResponse<T>(string uri)
        {
            T retVal;
            
            var request = WebRequest.Create(uri);
            var response = (HttpWebResponse)request.GetResponse();
            var beffer = string.Empty;
            using (Stream stream = response.GetResponseStream())
            {
                DataContractJsonSerializer ser = new DataContractJsonSerializer(typeof(T));
                retVal = (T)ser.ReadObject(stream);
            }


            return retVal;
        }

        public Event GetEvent(string eventId)
        {
            var url = string.Format(@"{0}events/{1}/?token={2}", baseUrl, eventId, apiToken);

            return GetResponse<Event>(url);
        }
        public Venue GetVenue(string venueId)
        {
            var url = string.Format(@"{0}venues/{1}/?token={2}", baseUrl, venueId, apiToken);

            return GetResponse<Venue>(url);
        }
    }
}
