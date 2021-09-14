using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class NewMailConfirmationPage : WebBasePage
    {
        public NewMailConfirmationPage()
        {
            pageLoadedElement = newMailHeading;
            correspondingDataClass = new NewMailConfirmationPageData().GetType();
            textName = "New Mail Confirmation Page";
        }
        public Element newMailHeading => new Element(FindElement("New mail", attributeType:Defs.locatorText, tag:"span"))
            .SetCompletePageFlag(false);
        public Element backToMessages => new Element(FindElement("Back to Messages", attributeType: Defs.locatorText, tag: "a"))
            .SetCompletePageFlag(false).SetIsButtonFlag(true);
    }

    public class NewMailConfirmationPageData : PageData
    {
    }
}
