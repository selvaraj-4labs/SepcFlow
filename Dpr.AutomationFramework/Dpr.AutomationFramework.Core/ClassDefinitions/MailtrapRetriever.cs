using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.TestEndClasses;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Savings;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions
{
    public class MailtrapRetriever
    {
        //string mailBoxId = SavingsStaticInfo.mailTrapInboxId;
        //string apiToken = SavingsStaticInfo.apiToken;

        string mailBoxId;
        string apiToken;

        public void SetMailBoxAccessDetails(string mailBox, string api)
        {
            mailBoxId = mailBox;
            apiToken = api;
        }

        public List<string> GetMailsContentSearchByDestinationAddressAndTitle(
            string toAddress, 
            string subject, 
            bool toAddressExactMatch = true, 
            bool subjectExactMatch = false, 
            int checkFirstXMsgs = 20, 
            DateTime? receivedAfter = null)
        {
            var client = new RestClient("https://mailtrap.io/api/v1");
            ServicePointManager.SecurityProtocol = 
                SecurityProtocolType.Tls12 | 
                SecurityProtocolType.Tls11 | 
                SecurityProtocolType.Tls;

            List<string> messageContentList = new List<string>();

            var request = new RestRequest("inboxes/" + mailBoxId + "/messages", Method.GET);

            // Add http headers. Provide api token and request responses in JSON format
            request.AddHeader("Api-Token", apiToken);
            request.AddHeader("Content-Type", "application/json");

            //Deserialise into List<Message>
            var response = client.Execute<List<Message>>(request);

            RestRequest msgRequest;
            int msgCounter = 0;
            if (response.Data != null)
            {
                foreach (Message m in response.Data)
                {
                    if ((toAddressExactMatch == true && m.to_email == toAddress) || 
                        (toAddressExactMatch == false && m.to_email.Contains(toAddress)))
                    {
                        if ((subjectExactMatch == true && m.subject == subject) || 
                            (subjectExactMatch == false && m.subject.Contains(subject)))
                        {

                            /* ORIGINAL
                             * if (receivedAfter == null || m.sent_at >= receivedAfter)
                             * Updated on 04062020 due to what I believe is a glitch with MailTrap and British Summer Time.
                             */
                            if (receivedAfter == null || m.sent_at.AddHours(1) >= receivedAfter)
                            {
                                msgRequest = new RestRequest(
                                    "inboxes/" + mailBoxId + "/messages/" + m.id + "/body.htmlsource",
                                    Method.GET);
                                msgRequest.AddHeader("Api-Token", apiToken);
                                msgRequest.AddHeader("Content-Type", "application/json");
                                messageContentList.Add(client.Execute(msgRequest).Content);
                            }
                        }

                    }
                    msgCounter++;
                    if (msgCounter == checkFirstXMsgs)
                    {
                        break;
                    }
                }
            }
            return messageContentList;
        }
    }
}
