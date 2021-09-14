using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP10_3 : CBS_DIP10
    {
        public CBS_DIP10_3()
        {
            pageLoadedElement = applicantName;
            correspondingDataClass = new CBS_DIP10_3Data().GetType();
            textName = "Applicant 3 Employment Summary";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_DIP10_3Data : CBS_DIP10Data
    {
    }
}

