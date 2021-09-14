using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.ClientPageRepository.CBS.BrokerPortal
{
    public class CBS_BrokerHomePage : BrokerHomePage
    {
        public CBS_BrokerHomePage()
        {
            pageLoadedElement = brokerHomeOption;
            correspondingDataClass = new CBS_BrokerHomePageData().GetType();
            textName = "CBS Broker Home Page";
        }
    }

    public class CBS_BrokerHomePageData : BrokerHomePageData
    {
        public new string brokerHomeOption { get; set; } = "ILL";
    }
}
