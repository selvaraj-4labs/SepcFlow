using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_PaymentConfirmationPage : PaymentConfirmationPage
    {
        public HEBS_PaymentConfirmationPage()
        {
            pageLoadedElement = homeBtn;
            correspondingDataClass = new HEBS_PaymentConfirmationPageData().GetType();
            textName = "Payment Confirmation Page";
        }
    }

    public class HEBS_PaymentConfirmationPageData : PaymentConfirmationPageData
    {
    }
}
