using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_CreditStub : CreditStub
    {
        public HEBS_CreditStub()
        {
            pageLoadedElement = creditPaymentBtn;
            correspondingDataClass = new CreditStubData().GetType();
            textName = "Credit Stub";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("HEBS_EAP19", "depositType", "Debit Card"))));
        }
    }
}
