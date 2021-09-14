using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_ForgottenPasswordPage : ForgottenPasswordPage
    {
        public HEBS_ForgottenPasswordPage()
        {
            pageLoadedElement = userId;
            correspondingDataClass = new HEBS_ForgottenPasswordPage().GetType();
            textName = "Ebanking forgotten password page";
        }
    }

    public class HEBS_ForgottenPasswordPageData : ForgottenPasswordPageData
    {
    }
}
