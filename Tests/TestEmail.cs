using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sunodia.ClassManagement.Utility.Email;

namespace Tests
{
    [TestClass]
    public class TestEmail
    {
        [TestMethod]
        public void TestMethod1()
        {
            MailjetEmail mail = new MailjetEmail();
            mail.SendEmail("22.00","test event","dan@rafferty.biz");

        }
    }
}
