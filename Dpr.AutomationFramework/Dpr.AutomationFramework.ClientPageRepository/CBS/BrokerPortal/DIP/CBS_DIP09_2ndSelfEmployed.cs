using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_2ndSelfEmployed : CBS_DIP09_SelfEmployed
    {
        public CBS_DIP09_2ndSelfEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_2ndSelfEmployedData().GetType();
            textName = "CBS Applicant 1 Secondary Employment Page - Self Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP08", "secondaryEmploymentStatus", "Self Employed"))));
        }
    }

    public class CBS_DIP09_2ndSelfEmployedData : CBS_DIP09_SelfEmployedData
    {
    }
}
