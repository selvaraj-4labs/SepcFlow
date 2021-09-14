using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.HEBS.eBankingPortal
{
    public class HEBS_YourContactDetails : YourContactDetails
    {
        public HEBS_YourContactDetails()
        {
            pageLoadedElement = homePhone;
            correspondingDataClass = new HEBS_YourContactDetailsData().GetType();
            textName = "EBanking Your Contact Details";
        }
    }

    public class HEBS_YourContactDetailsData : YourContactDetailsData
    {
    }
}
