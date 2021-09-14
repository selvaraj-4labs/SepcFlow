using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_MessageCentrePage : MessageCentrePage
    {
        public HEBS_MessageCentrePage()
        {
            pageLoadedElement = account;
            correspondingDataClass = new HEBS_MessageCentrePageData().GetType();
            textName = "EBanking Message Centre";
        }
    }

    public class HEBS_MessageCentrePageData : MessageCentrePageData
    {
    }
}
