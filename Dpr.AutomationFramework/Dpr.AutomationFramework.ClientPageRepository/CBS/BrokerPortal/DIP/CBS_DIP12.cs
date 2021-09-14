using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal.DIP
{
    public class CBS_DIP12 : Applicant1BTLPortfolioPage
    {
        public CBS_DIP12()
        {
            pageLoadedElement = ownAnyBTLProperties;
            correspondingDataClass = new CBS_DIP12Data().GetType();
            textName = "CBS Applicant 1 BTL Portfolio Page";
        }
    }

    public class CBS_DIP12Data : Applicant1BTLPortfolioPageData
    {

    }
}
