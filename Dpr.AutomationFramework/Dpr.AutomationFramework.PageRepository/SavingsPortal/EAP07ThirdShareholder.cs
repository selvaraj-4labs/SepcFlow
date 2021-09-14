using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP07ThirdShareholder : EAP07
    {
        public EAP07ThirdShareholder()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new EAP07ThirdShareholderData().GetType();
            textName = "Shareholder 3 Details";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "4"))));
        }
    }

    public class EAP07ThirdShareholderData : EAP07Data
    {
    }
}
