using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.RunBusinessRulesWizard
{
    public class RunBusinessRulesP3 : BOWizardBasePage
    {
        public RunBusinessRulesP3()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new RunBusinessRulesP3Data().GetType();
            textName = "Run Business Rules Page 3";
            windowTitle = "Run Business Rules";
        }
        public Element finish => new Element(FindElement("pnlNextButton", Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class RunBusinessRulesP3Data : PageData
    {
    }
}
