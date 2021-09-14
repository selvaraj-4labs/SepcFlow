using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_LoginDetailsConfirmationPage : LoginDetailsConfirmationPage
    {
        public HEBS_LoginDetailsConfirmationPage()
        {
            pageLoadedElement = hereBtn;
            correspondingDataClass = new HEBS_LoginDetailsConfirmationPageData().GetType();
            textName = "EBanking Login Details Confirmation Page";
        }
    }

    public class HEBS_LoginDetailsConfirmationPageData : LoginDetailsConfirmationPageData
    {
    }
}
