using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_2ndEmployed : CBS_DIP09_Employed
    {
        public CBS_DIP09_2ndEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_2ndEmployedData().GetType();
            textName = "CBS Applicant 1 Secondary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP08", "secondaryEmploymentStatus", "Employed"))));
        }
    }

    public class CBS_DIP09_2ndEmployedData : CBS_DIP09_EmployedData
    {
    }
}
