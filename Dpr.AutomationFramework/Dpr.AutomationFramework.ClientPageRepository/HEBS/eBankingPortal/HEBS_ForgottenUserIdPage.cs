using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_ForgottenUserIdPage : ForgottenUserIdPage
    {
        public HEBS_ForgottenUserIdPage()
        {
            pageLoadedElement = forgottenLoginDetailsHeader;
            correspondingDataClass = new HEBS_ForgottenUserIdPage().GetType();
            textName = "EBanking Forgotten User ID Page";
        }
    }

    public class HEBS_ForgottenUserIdPageData : ForgottenUserIdPageData
    {
    }
}
