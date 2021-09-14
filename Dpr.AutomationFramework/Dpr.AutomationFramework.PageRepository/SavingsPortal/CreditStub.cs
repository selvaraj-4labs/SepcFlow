using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{ 
    public class CreditStub : WebBasePage
    {
        public CreditStub()
        {
            pageLoadedElement = creditPaymentBtn;
            correspondingDataClass = new CreditStubData().GetType();
            textName = "Credit Stub";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("EAP19", "depositType", "Debit Card"))
            ));
        }
        public Element creditPaymentBtn => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorTitle, "Submit Payment")))
            .SetIsButtonFlag(true);
    }

    public class CreditStubData : PageData
    {
    }
}
