using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP07FourthShareholder : EAP07FourthShareholder
    {
        public HEBS_EAP07FourthShareholder()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new HEBS_EAP07FourthShareholderData().GetType();
            textName = "Shareholder 4 Details";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "4"))));
        }
    }

    public class HEBS_EAP07FourthShareholderData : EAP07FourthShareholderData
    {
    }
}
