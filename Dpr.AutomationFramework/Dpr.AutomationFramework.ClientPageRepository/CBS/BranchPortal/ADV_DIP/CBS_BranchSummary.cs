using Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BranchPortal.ADV_DIP
{
    public class CBS_BranchSummary : CBS_DIPAPPSUM
    {
        public CBS_BranchSummary()
        {
            pageLoadedElement = summaryPanel;
            correspondingDataClass = new CBS_BranchSummaryData().GetType();
            textName = "CBS Branch Application Summary Page";
        }
    }

    public class CBS_BranchSummaryData : CBS_DIPAPPSUMData
    {

    }
}
