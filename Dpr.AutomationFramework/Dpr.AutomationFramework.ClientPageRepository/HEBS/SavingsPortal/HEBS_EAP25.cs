using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP25 : EAP25
    {
        public HEBS_EAP25()
        {
            pageLoadedElement = makePaymentBtn;
            correspondingDataClass = new HEBS_EAP25Data().GetType();
            textName = "Debit Card Payment";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("HEBS_EAP19", "depositType", "Debit Card"))));
        }
    }

    public class HEBS_EAP25Data : EAP25Data
    {
    }
}
