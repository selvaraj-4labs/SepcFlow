using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_PBD04 : DecisionPage
    {
        public CBS_PBD04()
        {
            pageLoadedElement = decisionLbl;
            correspondingDataClass = new CBS_PBD04Data().GetType();
            textName = "CBS Decision Result Page";
        }
    }

    public class CBS_PBD04Data : DecisionData
    {
    }
}
