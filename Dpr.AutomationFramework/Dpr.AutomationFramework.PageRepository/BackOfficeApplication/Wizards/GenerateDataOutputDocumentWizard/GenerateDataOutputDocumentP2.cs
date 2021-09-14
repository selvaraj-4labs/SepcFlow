using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.GenerateDataOutputDocumentWizard
{
    public class GenerateDataOutputDocumentP2 : BOWizardBasePage
    {
        public GenerateDataOutputDocumentP2()
        {
            pageLoadedElement = new Element(FindElement("Confirm Business Rules Processing", attributeType: Defs.boLocatorName));
            correspondingDataClass = new GenerateDataOutputDocumentP2Data().GetType();
            textName = "Generate Data Output Document Page 2";
        }

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class GenerateDataOutputDocumentP2Data : PageData
    {
    }
}
