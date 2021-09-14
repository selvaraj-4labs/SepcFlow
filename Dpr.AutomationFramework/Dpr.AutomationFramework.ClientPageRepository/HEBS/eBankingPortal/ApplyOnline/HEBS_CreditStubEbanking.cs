using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_CreditStubEbanking : CreditStubEbanking
    {
        public HEBS_CreditStubEbanking()
        {
            pageLoadedElement = creditPaymentBtn;
            correspondingDataClass = new CreditStubEbankingData().GetType();
            textName = "Credit Stub Ebanking";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("HEBS_EAP19Ebanking", "depositType", "Debit Card"))));
        }
    }

    public class HEBS_CreditStubEbankingData : CreditStubEbankingData
    {
    }
}
