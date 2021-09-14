using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class PaymentConfirmationPage : WebBasePage
    {
        public PaymentConfirmationPage()
        {
            pageLoadedElement = homeBtn;
            correspondingDataClass = new PaymentConfirmationPageData().GetType();
            textName = "Payment Confirmation Page";
        }

        public Element homeBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorTitle, "Home")))
            .SetIsButtonFlag(true);


    }

    public class PaymentConfirmationPageData : PageData
    {
    }
}
