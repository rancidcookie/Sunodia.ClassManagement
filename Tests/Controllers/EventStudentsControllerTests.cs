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
    public class EventStudentsControllerTest
    {
        EventStudentsController eventStudentsController = new EventStudentsController();

        [TestInitialize]
        public void Init()
        {


        }
        [TestMethod]
        public void CanGetEventsStudents()
        {
            //var result = eventStudentsController.Search("","",2) as ViewResult;
            //var students = (List<Person>)result.ViewData.Model;
            //Assert.IsTrue(0 < students.Count);
        }
    }
}
