using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    // TODO: Complete when acces is granted.
    public class CBS_ADV_DIP17 : CBS_PBD04
    {
        public CBS_ADV_DIP17()
        {
            pageLoadedElement = decisionLbl;
            correspondingDataClass = new CBS_ADV_DIP17Data().GetType();
            textName = "CBS Branch Decision Result";
        }

        public new Element decisionResult => new Element(FindElement(
            new LocatorList()
                .Add(Defs.locatorId, "MainCnt_ucDecisionResult_ctl01_lblDecision")))
            .SetCompletePageFlag(false);

        public new Element provideAdditionalInformation => new Element(FindElement("txtOtherInfo"),
            new ConditionList()
                .Add(new Condition(decisionResult, "This case has been referred based on the information you have provided.", Defs.conditionTypeEqual)));

        public new Element nextBtn => new Element(FindElement("Next"), 
            new ConditionList()
                .Add(new Condition(decisionResult, "The mortgage application has been accepted.", Defs.conditionTypeEqual)))
                .SetIsButtonFlag(true);
    }

    public class CBS_ADV_DIP17Data : PageData
    {
    }
}
