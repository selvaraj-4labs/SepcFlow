using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{
    public class EAP25Ebanking : EAP25
    {
        public EAP25Ebanking()
        {
            pageLoadedElement = makePaymentBtn;
            correspondingDataClass = new EAP25EbankingData().GetType();
            textName = "Debit Card Payment Ebanking";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("EAP19Ebanking", "depositType", "Debit Card"))));
        }
    }

    public class EAP25EbankingData : EAP25Data
    {
    }
}
