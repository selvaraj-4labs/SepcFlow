using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class YourDetailsPage : WebBasePage
    {
        public YourDetailsPage()
        {
            pageLoadedElement = addressChange;
            correspondingDataClass = new YourDetailsPageData().GetType();
            textName = "EBanking Your Details";
        }
        public Element addressChange => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorText, "Address"), "/a"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element homePhoneChange => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorText, "Home phone"), "/a", "div"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element workPhoneChange => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorText, "Work phone"), "/a", "div"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element mobilePhoneChange => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorText, "Mobile phone"), "/a", "div"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element emailChange => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorText, "Email"), "/a", "div"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element changeContactPreferences => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div/div/div/article/div[4]/div[2]/div/div/div[3]/div/a"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element changeMarketingPreferences => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorId, "container"), "/section[4]/div/div/div/div/div/article/div[5]/div[2]/div/div/div[2]/div/a"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
        public Element changePassword => new Element(FindElement(new LocatorList()
            .Add(Defs.locatorText, "Change password"), tag: "a"))
            .SetIsButtonFlag(true)
            .SetCompletePageFlag(false);
    }

    public class YourDetailsPageData : PageData
    {
    }
}
