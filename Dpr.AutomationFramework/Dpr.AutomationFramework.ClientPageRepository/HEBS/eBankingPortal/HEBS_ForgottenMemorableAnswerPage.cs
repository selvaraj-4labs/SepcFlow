using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_ForgottenMemorableAnswerPage : ForgottenMemorableAnswerPage
    {
        public HEBS_ForgottenMemorableAnswerPage()
        {
            pageLoadedElement = userId;
            correspondingDataClass = new HEBS_ForgottenMemorableAnswerPage().GetType();
            textName = "Ebanking forgotten memorable answer page";
        }
    }

    public class HEBS_ForgottenMemorableAnswerPageData : ForgottenMemorableAnswerPageData
    {
    }
}
