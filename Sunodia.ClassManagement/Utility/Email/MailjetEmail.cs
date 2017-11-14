using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.Net.Mail;

using Mailjet.Client;
using Mailjet.Client.Resources;

namespace Sunodia.ClassManagement.Utility.Email
{
    public class MailjetEmail
    {
        public void SendEmail(string amountDue, string Event, string emailTo)
        {
            String APIKey = "8d63479f8c384ff6e02e5852527def96";
            String SecretKey = "6da9f03ac569f6df938f02ff23ad8c39";
            String From = "hello@sunodia.org";
            //String To = emailTo;
            //String To = "palmavista@gmail.com";
            String To = "dan@rafferty.biz";

            MailMessage msg = new MailMessage();
            msg.IsBodyHtml = true;

            msg.From = new MailAddress(From);

            msg.To.Add(new MailAddress(To));

            msg.Subject = "Your payment to Sunodia Prayer Counseling is due";
            msg.Body = string.Format("Thank for registering for our event, <i>{0}</i>. This is a reminder that you have a payment due of {1} for this event. You can make your payment online <a href=\"https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=VQNEG2TKZ5Q92\">here</a> or pay in person via cash, check, or credit card. If you have any questions, or if this reminder was sent in error, please contact us at <a href=\"mailto:hello@sunodia.org\">hello@sunodia.org</a>.</br></br>Thank you for your attention to this matter.</br></br>Your friends at Sunodía Prayer Counseling",Event, amountDue);

            SmtpClient client = new SmtpClient("in.mailjet.com", 587);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.UseDefaultCredentials = false;
            client.Credentials = new NetworkCredential(APIKey, SecretKey);

            client.Send(msg);
        }
        
        

    }
}
