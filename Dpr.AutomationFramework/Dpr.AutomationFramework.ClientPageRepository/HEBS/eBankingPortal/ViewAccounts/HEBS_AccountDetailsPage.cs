using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ViewAccounts;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ViewAccounts
{
    public class HEBS_AccountDetailsPage : AccountDetailsPage
    {
        public HEBS_AccountDetailsPage()
        {
            pageLoadedElement = transactions;
            correspondingDataClass = new HEBS_AccountDetailsPageData().GetType();
            textName = "EBanking Account Details Page";
        }
    }

    public class HEBS_AccountDetailsPageData : AccountDetailsPageData
    {

    }
}
