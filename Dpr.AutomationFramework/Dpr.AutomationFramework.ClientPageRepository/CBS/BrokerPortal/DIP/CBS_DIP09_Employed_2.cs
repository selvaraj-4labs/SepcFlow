using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_Employed_2 : CBS_DIP09_Employed
    {
        public CBS_DIP09_Employed_2()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_Employed_2Data().GetType();
            textName = "CBS Applicant 2 Primary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "2"))
                    .Add(new Condition("CBS_DIP08_2", "employmentStatus", "Employed")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "3"))
                    .Add(new Condition("CBS_DIP08_2", "employmentStatus", "Employed")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))
                    .Add(new Condition("CBS_DIP08_2", "employmentStatus", "Employed"))));
        }
    }
    public class CBS_DIP09_Employed_2Data : CBS_DIP09_EmployedData
    {
    }
}
