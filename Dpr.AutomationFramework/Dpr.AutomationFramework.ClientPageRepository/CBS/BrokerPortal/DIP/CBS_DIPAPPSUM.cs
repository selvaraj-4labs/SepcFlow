using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIPAPPSUM : ApplicationSummaryPage
    {
        public CBS_DIPAPPSUM()
        {
            pageLoadedElement = summaryPanel;
            correspondingDataClass = new CBS_DIPAPPSUMData().GetType();
            textName = "CBS Application Summary Page";
        }
    }
    public class CBS_DIPAPPSUMData : ApplicationSummaryPageData
    {
    }
}
