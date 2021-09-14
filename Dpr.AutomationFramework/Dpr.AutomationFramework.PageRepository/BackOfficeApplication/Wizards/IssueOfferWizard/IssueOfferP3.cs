using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.IssueOfferWizard
{
    public class IssueOfferP3 : BOWizardBasePage
    {
        public IssueOfferP3()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new IssueOfferP3Data().GetType();
            textName = "Issue Offer Page 3";
            windowTitle = "Issue Offer ";
        }

        public Element finish => new Element(FindElement(
                "Finish",
                attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);
    }

    public class IssueOfferP3Data : PageData
    {
    }
}