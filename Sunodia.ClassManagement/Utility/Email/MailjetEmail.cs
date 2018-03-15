using System;
using System.IO;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.Net;
using System.Net.Mail;
using Newtonsoft.Json.Linq;
using Mailjet.Client;
using Mailjet.Client.Resources;

namespace Sunodia.ClassManagement.Utility.Email
{
    public class MailjetEmail
    {
        String APIKey = "";
        String SecretKey = "";
        String From = "";
        String ToOverride = "";

        public MailjetEmail()
        {
            APIKey = ConfigurationManager.AppSettings["MailJetAPIKey"];
            SecretKey = ConfigurationManager.AppSettings["MailJetSecretKey"];
            From = ConfigurationManager.AppSettings["MailJetFrom"];
            ToOverride = ConfigurationManager.AppSettings["MailJetToOverride"];
            if (string.IsNullOrEmpty(APIKey))
            {
                //Loaddetails from a file
                var mailjetConfig = ConfigurationManager.AppSettings["MailJetConfig"];
                using (StreamReader reader = new StreamReader(mailjetConfig))
                {
                    APIKey = reader.ReadLine();
                    SecretKey = reader.ReadLine();
                    From = reader.ReadLine();
                    ToOverride = "dan@rafferty.biz";
                }
            }
            
        }

        public MailjetEmail(string apiKey, string secretKey, string from)
        {
            APIKey = apiKey;
            SecretKey = secretKey;
            From = from;
        }



        public async Task SendEmail(string amountDue, string Event,string emailTo)
        {
            if (!string.IsNullOrEmpty(ToOverride))
                emailTo = ToOverride;

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
                {"Email", From}
                }},
                {"To", new JArray {
                new JObject {
                {"Email", emailTo}
                }
                }},
                {"Bcc", new JArray {
                new JObject {
                {"Email", "dan@rafferty.biz"}
                },
                                new JObject {
                {"Email", "hello@sunodia.org"}
                }
                }},
                {"TemplateID",260145 },{"TemplateLanguage",true},{"Variables",new JObject{ {"EventName",Event},{"AmountDue",amountDue} } },
                {"Subject", "Your payment to Sunodia Prayer Counseling is due"},
                }
            });

                MailjetResponse response = await client.PostAsync(request);
            if (response.IsSuccessStatusCode)
            {    }
            else
            {
                    throw new Exception(string.Format("Failed to send email: StatusCode {0}, ErrorInfo: {1}, ErrorMessage: {2}", response.StatusCode, response.GetErrorInfo(), response.GetErrorMessage()));
            }
        }
    }
}




