using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP08_3 : CBS_DIP08
    {
        public CBS_DIP08_3()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new CBS_DIP08_3Data().GetType();
            textName = "CBS Applicant 3 Employment Initialisation Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_DIP08_3Data : CBS_DIP08Data
    {
    }
}
