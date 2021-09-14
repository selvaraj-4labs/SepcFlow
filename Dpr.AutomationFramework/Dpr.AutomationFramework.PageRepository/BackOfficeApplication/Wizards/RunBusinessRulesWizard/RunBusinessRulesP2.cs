using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.RunBusinessRulesWizard
{
    public class RunBusinessRulesP2 : BOWizardBasePage
    {
        public RunBusinessRulesP2()
        {
            pageLoadedElement = next;
            correspondingDataClass = new RunBusinessRulesP2Data().GetType();
            textName = "Run Business Rules Page 2";
            windowTitle = "Run Business Rules";
        }
        public Element next => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class RunBusinessRulesP2Data : PageData
    {
    }
}
