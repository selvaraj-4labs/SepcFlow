using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP07_4 : CBS_DIP07
    {
        public CBS_DIP07_4()
        {
            pageLoadedElement = everHadAUKAddress;
            correspondingDataClass = new CBS_DIP07_4Data().GetType();
            textName = "CBS Applicant 4 Address Histroy Page";
            pageCondition = new PageCondition(new Element(
                new ConditionList()
                    .Add(new Condition("CBS_DIP06", "numberOfApplicants", "4"))));
        }
    }

    public class CBS_DIP07_4Data : CBS_DIP07Data
    {
    }
}
