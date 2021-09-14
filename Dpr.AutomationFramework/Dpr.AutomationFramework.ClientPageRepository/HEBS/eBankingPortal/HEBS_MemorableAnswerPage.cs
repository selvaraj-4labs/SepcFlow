using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_MemorableAnswerPage : MemorableAnswerPage
    {
        public HEBS_MemorableAnswerPage()
        {
            pageLoadedElement = logon;
            correspondingDataClass = new HEBS_MemorableAnswerPageData().GetType();
            textName = "Memorable Answer Verification Page";
        }
    }

    public class HEBS_MemorableAnswerPageData : MemorableAnswerPageData
    {
    }
}
