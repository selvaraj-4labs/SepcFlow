using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP09_2ndEmployed : CBS_DIP09_2ndEmployed
    {
        public CBS_ADV_DIP09_2ndEmployed()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_ADV_DIP09_2ndEmployedData().GetType();
            textName = "CBS Advised Applicant 1 Secondary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP08", "secondaryEmploymentStatus", "Employed"))));
        }
    }

    public class CBS_ADV_DIP09_2ndEmployedData : CBS_DIP09_EmployedData
    {
    }
}
