using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_EAP25Ebanking : EAP25Ebanking
    {
        public HEBS_EAP25Ebanking()
        {
            pageLoadedElement = makePaymentBtn;
            correspondingDataClass = new HEBS_EAP25EbankingData().GetType();
            textName = "Debit Card Payment Ebanking";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("HEBS_EAP19Ebanking", "depositType", "Debit Card"))));
        }
    }

    public class HEBS_EAP25EbankingData : EAP25EbankingData
    {
    }
}
