using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_YourDetailsPage : YourDetailsPage
    {
        public HEBS_YourDetailsPage()
        {
            pageLoadedElement = addressChange;
            correspondingDataClass = new HEBS_YourDetailsPage().GetType();
            textName = "EBanking Your Details";
        }
    }

    public class HEBS_YourDetailsPageData : YourDetailsPageData
    {
    }
}
