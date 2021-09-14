using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.InstructValuationWizard
{
    public class InstructValuationP3 : BOWizardBasePage
    {
        public InstructValuationP3()
        {
            pageLoadedElement = finish;
            correspondingDataClass = new InstructValuationP3Data().GetType();
            textName = "Instruct Valution Page 3";
            windowTitle = "Instruct Valution";
        }

        public Element finish => new Element(FindElement(
                "Finish", 
                attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);
    }

    public class InstructValuationP3Data : PageData 
    { 
    }
}
