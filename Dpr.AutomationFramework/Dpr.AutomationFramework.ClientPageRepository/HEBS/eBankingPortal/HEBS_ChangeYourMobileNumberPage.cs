using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_ChangeYourMobileNumberPage : ChangeYourMobileNumberPage
    {
        public HEBS_ChangeYourMobileNumberPage()
        {
            pageLoadedElement = currentMobileNumber;
            correspondingDataClass = new HEBS_ChangeYourMobileNumberPageData().GetType();
            textName = "EBanking Your Contact Details";
        }
    }

    public class HEBS_ChangeYourMobileNumberPageData : ChangeYourMobileNumberPageData
    {
    }
}
