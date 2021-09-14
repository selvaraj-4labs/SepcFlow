using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_ConfirmPaymentDetails : ConfirmPaymentDetails
    {
        public HEBS_ConfirmPaymentDetails()
        {
            pageLoadedElement = confirmBtn;
            correspondingDataClass = new HEBS_ConfirmPaymentDetailsData().GetType();
            textName = "Confirm Payment Details Page";
        }
    }

    public class HEBS_ConfirmPaymentDetailsData : ConfirmPaymentDetails
    {
    }
}
