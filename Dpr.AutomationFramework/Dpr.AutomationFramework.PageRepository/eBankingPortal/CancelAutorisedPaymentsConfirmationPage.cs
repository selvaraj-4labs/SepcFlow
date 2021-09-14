using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class CancelAutorisedPaymentsConfirmationPage : WebBasePage
    {
        public CancelAutorisedPaymentsConfirmationPage()
        {
            pageLoadedElement = confirmCancelPaymentHeader;
            correspondingDataClass = new CancelAutorisedPaymentsConfirmationPageData().GetType();
            textName = "EBanking Cancel Authorised Payment Page";
        }
        public Element confirmCancelPaymentHeader => new Element(FindElement("=Confirm cancel payment", attributeType: Defs.locatorText, tag: "span"))
            .SetCompletePageFlag(false);

        public Element cancelPayment => new Element(FindElement("=Cancel Payment", attributeType: Defs.locatorValue))
            .SetIsButtonFlag(true);
    }

    public class CancelAutorisedPaymentsConfirmationPageData : PageData
    {
    }
}
