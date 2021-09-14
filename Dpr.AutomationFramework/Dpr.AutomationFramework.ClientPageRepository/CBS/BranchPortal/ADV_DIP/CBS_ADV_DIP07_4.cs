using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP07_4 : CBS_ADV_DIP07
    {
        public CBS_ADV_DIP07_4()
        {
            pageLoadedElement = everHadAUKAddress;
            correspondingDataClass = new CBS_ADV_DIP07_4Data().GetType();
            textName = "CBS Applicant 4 Address Histroy Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_ADV_DIP07_4Data : CBS_ADV_DIP07Data
    {
    }
}
