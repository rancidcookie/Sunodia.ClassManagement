using System;
using System.Collections.Generic;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sunodia.ClassManagement.Models;
using Sunodia.ClassManagement.Controllers;

namespace Tests.Controllers
{
    [TestClass]
    public class EventsControllerTest
    {
        EventsController eventController = new EventsController();

        [TestInitialize]
        public void Init()
        {
            

        }
        [TestMethod]
        public void CanGetEvents()
        {
            var result = eventController.Index() as ViewResult;
            var events = (List<Event>)result.ViewData.Model;
            Assert.IsTrue(0< events.Count);

        }
    }
}
