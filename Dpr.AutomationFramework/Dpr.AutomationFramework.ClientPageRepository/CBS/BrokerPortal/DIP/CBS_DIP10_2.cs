using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP10_2 : CBS_DIP10
    {
        public CBS_DIP10_2()
        {
            pageLoadedElement = applicantName;
            correspondingDataClass = new CBS_DIP10_2Data().GetType();
            textName = "Applicant 2 Employment Summary";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "2")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_DIP10_2Data : CBS_DIP10Data
    {
    }
}
