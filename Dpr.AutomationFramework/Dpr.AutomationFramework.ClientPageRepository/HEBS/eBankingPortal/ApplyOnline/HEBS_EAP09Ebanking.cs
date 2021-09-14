using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.SavingsPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_EAP09Ebanking : EAP09Ebanking
    {
        public HEBS_EAP09Ebanking()
        {
            pageLoadedElement = sortCode1Box;
            correspondingDataClass = new HEBS_EAP09EbankingData().GetType();
            textName = "Nominated Account Ebanking";
        }
    }

    public class HEBS_EAP09EbankingData : EAP09EbankingData
    {
    }
}
