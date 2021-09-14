using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.InstructValuationWizard
{
    public class InstructValuationP2 : BOWizardBasePage
    {
        public InstructValuationP2()
        {
            pageLoadedElement = next;
            correspondingDataClass = new InstructValuationP2Data().GetType();
            textName = "Instruct Valution Page 2";
            windowTitle = "Instruct Valution";
        }

        public Element next => new Element(FindElement(
            "pnlNextButton",
            attributeType: Defs.boLocatorAutomationId))
        .SetIsButtonFlag(true);
    }

    public class InstructValuationP2Data : PageData
    {

    }
}
