using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_ChangeYourPasswordPage : ChangeYourPasswordPage
    {
        public HEBS_ChangeYourPasswordPage()
        {
            pageLoadedElement = currentPassword;
            correspondingDataClass = new HEBS_ChangeYourPasswordPageData().GetType();
            textName = "EBanking Change your password";
        }
    }

    public class HEBS_ChangeYourPasswordPageData : ChangeYourPasswordPageData
    {
    }
}
