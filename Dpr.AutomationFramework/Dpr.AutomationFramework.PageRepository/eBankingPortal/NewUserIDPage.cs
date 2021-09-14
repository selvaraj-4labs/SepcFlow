using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class NewUserIDPage : WebBasePage
    {
        public NewUserIDPage()
        {
            pageLoadedElement = userNameBox;
            correspondingDataClass = new NewUserIDPageData().GetType();
            textName = "New User ID Page";
        }

        public Element userNameBox => new Element(FindElement("Username"));

        public new Element saveBtn => new Element(FindElement(
            new LocatorList()
            .Add(Defs.locatorValue, "Save")))
            .SetIsButtonFlag(true);
    }

    public class NewUserIDPageData : PageData
    {

        public string userName { get; set; }
     
    }
}
