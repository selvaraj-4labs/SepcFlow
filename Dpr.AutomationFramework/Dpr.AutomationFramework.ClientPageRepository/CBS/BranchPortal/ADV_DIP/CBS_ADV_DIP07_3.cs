using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_ADV_DIP07_3 : CBS_ADV_DIP07
    {
        public CBS_ADV_DIP07_3()
        {
            pageLoadedElement = everHadAUKAddress;
            correspondingDataClass = new CBS_ADV_DIP07_3Data().GetType();
            textName = "CBS Applicant 3 Address Histroy Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP06", "numberOfApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_ADV_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_ADV_DIP07_3Data : CBS_ADV_DIP07Data
    {
    }
}
