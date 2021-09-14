
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.IntermediaryPortal.DIP
{
    public class BrokerHomePage : WebBasePage
    {

        public BrokerHomePage()
        {
            pageLoadedElement = brokerHomeOption;
            correspondingDataClass = new BrokerHomePageData().GetType();
            textName = "Broker Home Page";
        }

        public Element brokerHomeOption => new Element(new ButtonGroup()
            .AddButtonElement("DIP", FindElement("=DIP", attributeType: Defs.locatorTitle, tag: "a"))
            .AddButtonElement("ILL", FindElement("=Illustration", attributeType: Defs.locatorTitle, tag: "a")));
    }

    public class BrokerHomePageData : PageData
    {
        public string brokerHomeOption { get; set; } = "DIP";
    }
}
