using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_2ndFTC : CBS_DIP09_FTC
    {
        public CBS_DIP09_2ndFTC()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_2ndFTCData().GetType();
            textName = "CBS Applicant 1 Secondary Employment Page - Fixed Term Contract";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP08", "secondaryEmploymentStatus", "Fixed Term Contract"))));
        }
    }

    public class CBS_DIP09_2ndFTCData : CBS_DIP09_FTCData
    {
    }
}
