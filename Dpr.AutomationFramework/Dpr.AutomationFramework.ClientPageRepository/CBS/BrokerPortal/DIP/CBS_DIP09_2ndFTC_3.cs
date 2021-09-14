using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_2ndFTC_3 : CBS_DIP09_FTC
    {
        public CBS_DIP09_2ndFTC_3()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_2ndFTC_3Data().GetType();
            textName = "CBS Applicant 3 Secondary Employment Page - Fixed Term Contract";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "3"))
                    .Add(new Condition("CBS_DIP08_3", "secondaryEmploymentStatus", "Fixed Term Contract")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))
                    .Add(new Condition("CBS_DIP08_3", "secondaryEmploymentStatus", "Fixed Term Contract"))));
        }
    }
    public class CBS_DIP09_2ndFTC_3Data : CBS_DIP09_FTCData
    {
    }
}

