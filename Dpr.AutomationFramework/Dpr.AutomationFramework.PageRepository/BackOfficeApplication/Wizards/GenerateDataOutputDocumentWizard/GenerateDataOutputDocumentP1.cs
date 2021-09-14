using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.GenerateDataOutputDocumentWizard
{
    public class GenerateDataOutputDocumentP1 : BOWizardBasePage
    {
        public GenerateDataOutputDocumentP1()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new GenerateDataOutputDocumentP1Data().GetType();
            textName = "Generate Data Output Document Page 1";
        }

        // Why is this not being found??

        /*public Element anonymisationStatus => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboAnonymizationStatus"),
            "/Edit"));
        */
        public Element selectApplicantLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ApplicantSource"),
            "/Edit", 
            tag: "ComboBox"));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }



    public class GenerateDataOutputDocumentP1Data : PageData
    {
        public string selectApplicant { get; set; } = null;
    }
}
