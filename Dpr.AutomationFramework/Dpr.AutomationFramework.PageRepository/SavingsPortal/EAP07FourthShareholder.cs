using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal
{
    public class EAP07FourthShareholder : EAP07
    {
        public EAP07FourthShareholder()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new EAP07FourthShareholderData().GetType();
            textName = "Shareholder 4 Details";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("EAP06", "numberOfOtherApplicants", "4"))));
        }
    }

    public class EAP07FourthShareholderData : EAP07Data
    {
    }
}
