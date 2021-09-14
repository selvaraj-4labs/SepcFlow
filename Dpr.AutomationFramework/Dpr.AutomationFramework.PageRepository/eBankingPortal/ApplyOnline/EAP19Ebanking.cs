using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline
{
    public class EAP19Ebanking : EAP19
    {
        public EAP19Ebanking()
        {
            pageLoadedElement = pledgeAmountBox;
            correspondingDataClass = new EAP19EbankingData().GetType();
            textName = "Payment Options Ebanking";
        }
    }

    public class EAP19EbankingData : EAP19Data
    {
    }
}
