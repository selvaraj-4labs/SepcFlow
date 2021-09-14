using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using System;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class EnterPaymentDetailsPage : WebBasePage
    {
        public EnterPaymentDetailsPage()
        {
            pageLoadedElement = toAccountLookup;
            correspondingDataClass = new EnterPaymentDetailsPageData().GetType();
            textName = "Enter Payment Details Page";
        }


        public Element fromAccount => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"),
            "/section[4]/div/div/div/div/div/article/form/div[2]/div[2]/div/div/div[1]/div[2]"))
            .SetCompletePageFlag(false);

        public Element toAccountLookup => new Element(FindElement("PayToAccount"));

        public Element amountBox => new Element(FindElement("Amount"));

        public Element dateRbtn => new Element(new RadioButton()
                                    .AddRadioButtonElement("Pay ASAP", FindElement("PayImmediately", "_Yes"))
                                    .AddRadioButtonElement("Leave my account on", FindElement("PayImmediately", "_No")));

        public Element paymentDate => new Element(FindElement("PaymentDate"), new ConditionList()
            .Add(new Condition(className, "date", "Leave my account on")));

        public Element nextBtn => new Element(FindElement(new LocatorList()
                                    .Add(Defs.locatorValue, "Next")))
                                    .SetIsButtonFlag(true);
    }

    public class EnterPaymentDetailsPageData : PageData
    {

        public EnterPaymentDetailsPageData()
        {
            paymentDate = DateTime.Today.AddDays(1).ToString("dd/MM/yyyy");
        }
        public string toAccount { get; set; } = "Test Account 070116 02971797";

        public string amount { get; set; } = "1000";

        public string date { get; set; } = "Pay ASAP";

        public string paymentDate { get; set; } 
    }
}
