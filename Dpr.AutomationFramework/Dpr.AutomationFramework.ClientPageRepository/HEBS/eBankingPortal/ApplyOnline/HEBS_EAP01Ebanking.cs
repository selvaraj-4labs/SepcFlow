using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_EAP01Ebanking : EAP01Ebanking
    {
        public HEBS_EAP01Ebanking()
        {
            pageLoadedElement = acceptDeclarationChbox;
            correspondingDataClass = new HEBS_EAP01EbankingData().GetType();
            textName = "Entry Page Retail Ebanking";
        }
    }

    public class HEBS_EAP01EbankingData : EAP01EbankingData
    {
    }
}
