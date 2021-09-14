using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_EAP19Ebanking : EAP19Ebanking
    {
        public HEBS_EAP19Ebanking()
        {
            pageLoadedElement = pledgeAmountBox;
            correspondingDataClass = new HEBS_EAP19EbankingData().GetType();
            textName = "Payment Options Ebanking";
        }
    }

    public class HEBS_EAP19EbankingData : EAP19EbankingData
    {
    }
}
