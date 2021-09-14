using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_CancelAutorisedPaymentsConfirmationPage : CancelAutorisedPaymentsConfirmationPage
    {
        public HEBS_CancelAutorisedPaymentsConfirmationPage()
        {
            pageLoadedElement = confirmCancelPaymentHeader;
            correspondingDataClass = new HEBS_CancelAutorisedPaymentsConfirmationPageData().GetType();
            textName = "EBanking Cancel Authorised Payment Page";
        }
    }

    public class HEBS_CancelAutorisedPaymentsConfirmationPageData : CancelAutorisedPaymentsConfirmationPageData
    {
    }
}
