using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Eventbrite;

namespace Tests
{
    [TestClass]
    public class EventBriteTests
    {
        [TestMethod]
        public void CanGetOrders()
        {
            Context context = new Context();
            var orders = context.GetOrders("34912353790");

            Assert.AreEqual("", orders.orders.First().name);

        }

        [TestMethod]
        public void CanGetEvents()
        {
            Context context = new Context();
            DateTime newerThan = new DateTime(2012, 1, 1);
            var events = context.GetEventsNewerThan(newerThan);


        }

        [TestMethod]
        public void CanGetEvent()
        {
            Context context = new Context();
            var events = context.GetEvent("34912353790");

            Assert.AreEqual("", events.name);
        }
        [TestMethod]
        public void CanGetVenue()
        {
            Context context = new Context();
            var venue = context.GetVenue("21687115");

            Assert.AreEqual("Sunodía Prayer Counseling", venue.name);


        }
    }
}
