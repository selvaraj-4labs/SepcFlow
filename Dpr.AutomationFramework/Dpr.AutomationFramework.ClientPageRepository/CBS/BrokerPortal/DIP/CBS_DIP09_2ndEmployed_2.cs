using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP09_2ndEmployed_2 : CBS_DIP09_2ndEmployed
    {
        public CBS_DIP09_2ndEmployed_2()
        {
            pageLoadedElement = fullTime;
            correspondingDataClass = new CBS_DIP09_2ndEmployed_2Data().GetType();
            textName = "CBS Applicant 2 Secondary Employment Page - Employed";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "2"))
                    .Add(new Condition("CBS_DIP08_2", "secondaryEmploymentStatus", "Employed")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "3"))
                    .Add(new Condition("CBS_DIP08_2", "secondaryEmploymentStatus", "Employed")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))
                    .Add(new Condition("CBS_DIP08_2", "secondaryEmploymentStatus", "Employed"))));
        }
    }

    public class CBS_DIP09_2ndEmployed_2Data : CBS_DIP09_2ndEmployedData
    {
    }
}
