using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_NewMailPage : NewMailPage
    {
        public HEBS_NewMailPage()
        {
            pageLoadedElement = account;
            correspondingDataClass = new HEBS_NewMailPageData().GetType();
            textName = "New Mail Page";
        }
    }

    public class HEBS_NewMailPageData : NewMailPageData
    {
    }
}
