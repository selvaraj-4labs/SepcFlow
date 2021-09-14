using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal.ApplyOnline;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal.ApplyOnline
{
    public class HEBS_EbankingApplyOnline : EbankingApplyOnline
    {
        public HEBS_EbankingApplyOnline()
        {
            pageLoadedElement = name;
            correspondingDataClass = new HEBS_EbankingApplyOnlineData().GetType();
            textName = "EBanking Apply Online";
        }
    }

    public class HEBS_EbankingApplyOnlineData : EbankingApplyOnlineData
    {
    }
}
