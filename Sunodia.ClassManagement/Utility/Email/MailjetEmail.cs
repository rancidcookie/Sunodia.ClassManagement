using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;

namespace Sunodia.ClassManagement.Utility.Email
{
    public class MailjetEmail
    {
        public static async Task SendEmail(string amountDue, string Event, string emailTo)
        {
            //SendTest(amountDue, Event, emailTo).Wait();
            //return; 

            String APIKey = "b42024e62586df2dd5334d106da69f3f";
            String SecretKey = "3e3c7b4af713a5c32ddb8cabac9cdbdc";
            String From = "hello@sunodia.org";
            //String To = emailTo;
            //String To = "palmavista@gmail.com";
            //String To = "dan@rafferty.biz";
            String To = "support+806416@mailjet.com";
            

            //MailMessage msg = new MailMessage();
            //msg.IsBodyHtml = true;

            //msg.From = new MailAddress(From);

            //msg.To.Add(new MailAddress(To));

            var subject = "Sunodia Prayer Counseling Event";
            //msg.Body = string.Format("Thank for registering for our event, <i>{0}</i>. This is a reminder that you have a payment due of {1} for this event. You can make your payment online <a href=\"https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=VQNEG2TKZ5Q92\">here</a> or pay in person via cash, check, or credit card. If you have any questions, or if this reminder was sent in error, please contact us at <a href=\"mailto:hello@sunodia.org\">hello@sunodia.org</a>.</br></br>Thank you for your attention to this matter.</br></br>Your friends at Sunodía Prayer Counseling", Event, amountDue);

            MailjetClient client = new MailjetClient(APIKey, SecretKey) { Version = ApiVersion.V3_1 };
            MailjetRequest request = new MailjetRequest { Resource = Send.Resource }
            .Property(Send.Messages, new JArray {
                new JObject {
                    { "From",new JObject {
                        { "Email", From },
                        { "Name","Sunodía Prayer Counseling" }
                    } },
                { "To", new JArray { new JObject
                {
                    {"Email", To },
                    {"Name",To }
                }
                }},
            { "TemplateID", 260145},
            { "TemplateLanguage",true},
            { "Subject", subject},
                    {"Variables", new JObject
                    {
                        {"Event", Event },
                        {"AmountDue",amountDue }
                    } },
                    //{"TextPart", "tests" }
        }
    });
            MailjetResponse response = await client.PostAsync(request);
            if(!response.IsSuccessStatusCode)
            {
                //Handle error
            }


        }
        
        

    

    private static async Task SendTest(string amountDue, string Event, string emailTo)
    {
            String APIKey = "b42024e62586df2dd5334d106da69f3f ";
            String SecretKey = "3e3c7b4af713a5c32ddb8cabac9cdbdc ";
            String From = "hello@sunodia.org";
            //String To = emailTo;
            //String To = "palmavista@gmail.com";
            String To = "dan@rafferty.biz";


            MailjetClient client = new MailjetClient(APIKey, SecretKey)
            {
                Version = ApiVersion.V3_1,
            };
            MailjetRequest request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
           .Property(Send.Messages, new JArray {
                new JObject {
                 {"From", new JObject {
                  {"Email", "dan@rafferty.biz"},
                  {"Name", "Mailjet Pilot"}
                  }},
                 {"To", new JArray {
                  new JObject {
                   {"Email", "dan@rafferty.biz"},
                   {"Name", "passenger 1"}
                   }
                  }},
                 {"Subject", "Your email flight plan!"},
                 {"TextPart", "Dear passenger 1, welcome to Mailjet! May the delivery force be with you!"},
                 {"HTMLPart", "<h3>Dear passenger 1, welcome to Mailjet!</h3><br />May the delivery force be with you!"}
                 }
               });
        MailjetResponse response = await client.PostAsync(request);

    }
    }
}
