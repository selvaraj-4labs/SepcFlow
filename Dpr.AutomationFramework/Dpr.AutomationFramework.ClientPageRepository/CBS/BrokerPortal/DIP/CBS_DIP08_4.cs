using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP08_4 : CBS_DIP08
    {
        public CBS_DIP08_4()
        {
            pageLoadedElement = employmentStatus;
            correspondingDataClass = new CBS_DIP08_4Data().GetType();
            textName = "CBS Applicant 4 Employment Initialisation Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_DIP08_4Data : CBS_DIP08Data
    {
    }
}
