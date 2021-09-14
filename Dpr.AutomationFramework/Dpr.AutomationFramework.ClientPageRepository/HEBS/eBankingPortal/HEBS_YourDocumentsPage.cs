using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_YourDocumentsPage : YourDocumentsPage
    {
        public HEBS_YourDocumentsPage()
        {
            pageLoadedElement = account;
            correspondingDataClass = new HEBS_YourDocumentsPageData().GetType();
            textName = "EBanking Your Documents";
        }
    }

    public class HEBS_YourDocumentsPageData : YourDocumentsPageData
    {
    }
}