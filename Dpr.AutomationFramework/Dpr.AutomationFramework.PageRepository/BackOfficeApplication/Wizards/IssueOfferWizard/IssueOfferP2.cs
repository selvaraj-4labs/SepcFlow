using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.IssueOfferWizard
{
    public class IssueOfferP2 : BOWizardBasePage
    {
        public IssueOfferP2()
        {
            pageLoadedElement = next;
            correspondingDataClass = new IssueOfferP2Data().GetType();
            textName = "Issue Offer Page 2";
            windowTitle = "Issue Offer ";
        }

        public Element next => new Element(FindElement(
            "pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
        .SetIsButtonFlag(true);
    }

    public class IssueOfferP2Data : PageData
    {
    }
}
