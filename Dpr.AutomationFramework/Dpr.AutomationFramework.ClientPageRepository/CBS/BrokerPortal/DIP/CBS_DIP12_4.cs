using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP12_4 : CBS_DIP12
    {
        public CBS_DIP12_4()
        {
            pageLoadedElement = ownAnyBTLProperties;
            correspondingDataClass = new CBS_DIP12_4Data().GetType();
            textName = "CBS Applicant 4 BTL Portfolio Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_DIP12_4Data : CBS_DIP11Data
    {
    }
}
