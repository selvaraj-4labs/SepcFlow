using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_EBankingLoginPage : EBankingLoginPage
    {
        public HEBS_EBankingLoginPage()
        {
            pageLoadedElement = continueBtn;
            correspondingDataClass = new EBankingLoginPageData().GetType();
            textName = "EBanking Login Page";
        }
    }

    public class HEBS_EBankingLoginPageData : EBankingLoginPageData
    {
    }
}
