using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP07_2 : CBS_DIP07
    {
        public CBS_DIP07_2()
        {
            pageLoadedElement = everHadAUKAddress;
            correspondingDataClass = new CBS_DIP07_2Data().GetType();
            textName = "CBS Applicant 2 Address Histroy Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "2")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "3")))
                .AddNewConditionList(new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_DIP07_2Data : CBS_DIP07Data
    {
    }
}
