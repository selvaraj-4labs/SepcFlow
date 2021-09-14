using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP07SecondShareholder : EAP07
    {
        public EAP07SecondShareholder()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new EAP07SecondShareholderData().GetType();
            textName = "Shareholder 2 Details";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "2")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "4"))));
        }
    }

    public class EAP07SecondShareholderData : EAP07Data
    {
    }
}
