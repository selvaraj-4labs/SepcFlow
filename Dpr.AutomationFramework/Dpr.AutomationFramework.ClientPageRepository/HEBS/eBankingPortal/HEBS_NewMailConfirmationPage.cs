using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_NewMailConfirmationPage : NewMailConfirmationPage
    {
        public HEBS_NewMailConfirmationPage()
        {
            pageLoadedElement = newMailHeading;
            correspondingDataClass = new HEBS_NewMailConfirmationPageData().GetType();
            textName = "New Mail Confirmation Page";
        }
    }

    public class HEBS_NewMailConfirmationPageData : NewMailConfirmationPageData
    {
    }
}
