using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendSecurityWizard
{
    public class AmendSecurityP4 : BOWizardBasePage
    {
        public AmendSecurityP4()
        {
            pageLoadedElement = next;
            correspondingDataClass = new AmendSecurityP4Data().GetType();
            textName = "Amend Security Page 4";
            windowTitle = "Amend Security";
        }
        public Element next => new Element(FindElement(
            "pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
        .SetIsButtonFlag(true);
    }

    public class AmendSecurityP4Data : PageData
    {
    }
}
