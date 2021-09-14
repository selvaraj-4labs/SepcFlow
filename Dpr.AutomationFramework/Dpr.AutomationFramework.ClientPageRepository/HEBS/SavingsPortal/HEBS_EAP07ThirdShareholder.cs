using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP07ThirdShareholder : EAP07ThirdShareholder
    {
        public HEBS_EAP07ThirdShareholder()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new HEBS_EAP07ThirdShareholderData().GetType();
            textName = "Shareholder 3 Details";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "4"))));
        }
    }

    public class HEBS_EAP07ThirdShareholderData : EAP07ThirdShareholderData
    {
    }
}
