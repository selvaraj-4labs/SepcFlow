using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_SelfEmployed_4 : CBS_DIP09_SelfEmployed
    {
        public CBS_DIP09_SelfEmployed_4()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_SelfEmployed_4Data().GetType();
            textName = "CBS Applicant 4 Primary Employment Page - Self Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))
                    .Add(new Condition("CBS_DIP08_4", "employmentStatus", "Self Employed"))));
        }
    }

    public class CBS_DIP09_SelfEmployed_4Data : CBS_DIP09_SelfEmployedData
    {
    }
}
