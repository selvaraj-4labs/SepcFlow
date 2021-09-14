using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.CompleteCaseWizard
{

    public class CompleteCaseP4 : BOWizardBasePage
    {   
        public CompleteCaseP4()
        {
            pageLoadedElement = resultTable;
            correspondingDataClass = new CompleteCaseP4Data().GetType();
            textName = "Complete Case Page 4";
        }

        public Element resultTable => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "Processing Completion"),
            tag: "DataItem"));

        public Element finishBtn => new Element(FindElement("Finish", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);
    }

    public class CompleteCaseP4Data : PageData
    {
    }

}
