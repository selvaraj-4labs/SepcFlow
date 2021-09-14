using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendSecurityWizard
{
    public class AmendSecurityP1 : BOWizardBasePage
    {
        public AmendSecurityP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new AmendSecurityP1Data().GetType();
            textName = "Amend Security Page 1";
            windowTitle = "Amend Security";
        }

        public Element selectTheReqeuiredSecurity => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceSecurity")));

        public Element selectTheRequiredAction => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "uceAction")));

        public Element next => new Element(FindElement(
            "pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
        .SetIsButtonFlag(true);
    }

    public class AmendSecurityP1Data : PageData
    {
        public string selectTheRequiredAction { get; set; } = "Correct Address";
    }
}
