using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.FMA
{
    public class FMA_CreditStub : WebBasePage
    {
        public FMA_CreditStub()
        {
            pageLoadedElement = creditPayment;
            correspondingDataClass = new FMA_CreditStubData().GetType();
            textName = "FMA Credit Stub";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("FMA_PaymentDetailsPage", "makePaymentAndSubmit", "Make Payment & Submit"))
            ));
        }
        public Element creditPayment => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorTitle, "Submit Payment")))
            .SetIsButtonFlag(true);
    }

    public class FMA_CreditStubData : PageData
    {
        public string creditPayment { get; set; } = "Submit Payment";
    }
}