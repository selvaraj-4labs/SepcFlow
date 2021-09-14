using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.SavingsPortal
{
    public class HEBS_EAP07SecondShareholder : EAP07SecondShareholder
    {
        public HEBS_EAP07SecondShareholder()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new HEBS_EAP07SecondShareholderData().GetType();
            textName = "Shareholder 2 Details";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "2")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("HEBS_EAP06", "numberOfOtherApplicants", "4"))));
        }
    }

    public class HEBS_EAP07SecondShareholderData : EAP07SecondShareholderData
    {
    }
}
