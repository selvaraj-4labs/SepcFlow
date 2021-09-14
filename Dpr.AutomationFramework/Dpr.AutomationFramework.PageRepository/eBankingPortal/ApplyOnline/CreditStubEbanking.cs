using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{
    public class CreditStubEbanking : CreditStub
    {
        public CreditStubEbanking()
        {
            pageLoadedElement = creditPaymentBtn;
            correspondingDataClass = new CreditStubEbankingData().GetType();
            textName = "Credit Stub Ebanking";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("EAP19Ebanking", "depositType", "Debit Card"))));
        }
    }

    public class CreditStubEbankingData : CreditStubData
    {
    }
}
