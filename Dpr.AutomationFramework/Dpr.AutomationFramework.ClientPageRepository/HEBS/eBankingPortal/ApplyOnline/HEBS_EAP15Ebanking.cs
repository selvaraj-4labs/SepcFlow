using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_EAP15Ebanking : EAP15Ebanking
    {
        public HEBS_EAP15Ebanking()
        {
            pageLoadedElement = fscsChbox;
            correspondingDataClass = new HEBS_EAP15EbankingData().GetType();
            textName = "Summary Ebanking";
        }
    }

    public class HEBS_EAP15EbankingData : EAP15EbankingData
    {
    }
}
