using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.ProcessCOTWizard
{
    public class ProcessCOTP3 : BOWizardBasePage
    {
        public ProcessCOTP3()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new ProcessCOTP3Data().GetType();
            textName = "Process COT Page 3";
            windowTitle = "Process COT /Change Approved";
        }
        public Element finish => new Element(FindElement(
                "Finish",
                attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);
    }

    public class ProcessCOTP3Data : PageData
    {
    }
}
