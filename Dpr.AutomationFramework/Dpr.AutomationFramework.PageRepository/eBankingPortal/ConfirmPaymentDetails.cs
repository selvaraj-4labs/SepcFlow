using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class ConfirmPaymentDetails : WebBasePage
    {
        public ConfirmPaymentDetails()
        {
            pageLoadedElement = confirmBtn;
            correspondingDataClass = new ConfirmPaymentDetailsData().GetType();
            textName = "Confirm Payment Details Page";
        }
        public Element confirmBtn => new Element(FindElement(new LocatorList()
                                        .Add(Defs.locatorValue, "Confirm")))
                                        .SetIsButtonFlag(true);
    }

    public class ConfirmPaymentDetailsData : PageData
    {
    }
}
