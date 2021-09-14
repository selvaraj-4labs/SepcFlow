using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP12_4 : CBS_ADV_DIP12
    {
        public CBS_ADV_DIP12_4()
        {
            pageLoadedElement = ownAnyBTLProperties;
            correspondingDataClass = new CBS_ADV_DIP12_4Data().GetType();
            textName = "CBS Advised Applicant 4 BTL Portfolio Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_ADV_DIP12_4Data : CBS_ADV_DIP12Data
    {
    }
}
