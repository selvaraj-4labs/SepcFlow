using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.eBankingPortal
{
    public class NewMailPage : WebBasePage
    {
        public NewMailPage()
        {
            pageLoadedElement = account;
            correspondingDataClass = new NewMailPageData().GetType();
            textName = "New Mail Page";
        }
        public Element account => new Element(FindElement("AccountNo"));
        public Element subject => new Element(FindElement("CommunicationType"));
        public Element message => new Element(FindElement("Message"));
        public Element submit => new Element(FindElement("Submit", attributeType: Defs.locatorValue))
            .SetIsButtonFlag(true);
    }

    public class NewMailPageData : PageData
    { 
        public string account { get; set; } = null; 
        public string subject { get; set; } = "test subject";
        public string message { get; set; } = "test message";
    }
}
