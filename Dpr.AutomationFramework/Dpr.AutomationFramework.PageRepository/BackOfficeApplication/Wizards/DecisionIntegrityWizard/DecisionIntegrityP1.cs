using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.DecisionIntegrityWizard
{
    public class DecisionIntegrityP1 : BOWizardBasePage
    {
        // Only one page in this wizard.
        public DecisionIntegrityP1()
        {
            pageLoadedElement = next;
            correspondingDataClass = new DecisionIntegrityP1Data().GetType();
            textName = "Decision Integrity Page 1";
            windowTitle = "Decision Integrity";
        }
        public Element next => new Element(FindElement(
                "pnlNextButton",
                attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class DecisionIntegrityP1Data : PageData 
    {
    }
}
