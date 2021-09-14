using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.GenerateDataOutputDocumentWizard
{
    public class GenerateDataOutputDocumentP3 : BOWizardBasePage
    {
        public GenerateDataOutputDocumentP3()
        {
            pageLoadedElement = resultTable;
            correspondingDataClass = new GenerateDataOutputDocumentP3Data().GetType();
            textName = "Generate Data Output Document Page 3";
        }
        public Element resultTable => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorName, "Generate Applicant/Customer Data Document"),
            tag: "DataItem"));

        public Element finishBtn => new Element(FindElement("Finish", attributeType: Defs.boLocatorName))
            .SetIsButtonFlag(true);

    }

    public class GenerateDataOutputDocumentP3Data : PageData
    {
    }
}
