using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_EnterPaymentDetailsPage : EnterPaymentDetailsPage
    {
        public HEBS_EnterPaymentDetailsPage()
        {
            pageLoadedElement = toAccountLookup;
            correspondingDataClass = new EnterPaymentDetailsPageData().GetType();
            textName = "Enter Payment Details Page";
        }
    }

    public class HEBS_EnterPaymentDetailsPageData : EnterPaymentDetailsPageData
    {
    }
}
