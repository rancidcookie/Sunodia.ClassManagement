using System;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sunodia.ClassManagement.Utility.Email;

namespace Tests
{
    [TestClass]
    public class TestEmail
    {
        [TestMethod]
        public async Task CanSendEmail()
        {
            MailjetEmail mail = new MailjetEmail();
            await mail.SendEmail("22.00","test event", "dan@rafferty.biz");

        }


    }
}
