using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Sunodia.ClassManagement.Utility.Eventbrite;

namespace Tests
{
    [TestClass]
    public class EventBriteTests
    {
        [TestMethod]
        public void CanGetOrders()
        {
            EBContext context = new EBContext();
            var orders = context.GetOrders("41144700908");

            Assert.AreEqual("", orders.orders.First().name);

        }

        [TestMethod]
        public void CanGetEvents()
        {
            EBContext context = new EBContext();
            DateTime newerThan = new DateTime(2017, 1, 1);
            var events = context.GetEventsNewerThan(newerThan);
            foreach(var ebEvent in events)
            {
                var orders = context.GetOrders(ebEvent.id);
                if(orders.orders.Count() > 0)
                {
                    foreach(var order in orders.orders)
                    {
                        var result = order.last_name;
                    }
                }

            }


        }

        [TestMethod]
        public void CanGetEvent()
        {
            EBContext context = new EBContext();
            var events = context.GetEvent("34912353790");

            Assert.AreEqual("", events.name);
        }
        [TestMethod]
        public void CanGetVenue()
        {
            EBContext context = new EBContext();
            var venue = context.GetVenue("21687115");

            Assert.AreEqual("Sunodía Prayer Counseling", venue.name);


        }
    }
}
