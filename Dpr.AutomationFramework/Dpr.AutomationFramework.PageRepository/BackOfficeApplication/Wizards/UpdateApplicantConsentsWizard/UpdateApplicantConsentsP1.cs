using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.GenerateDataOutputDocumentWizard
{
    public class UpdateApplicantConsentsP1 : BOWizardBasePage
    {
        public UpdateApplicantConsentsP1()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new UpdateApplicantConsentsP1Data().GetType();
            textName = "Update Applicant Consents Page 1";
            windowTitle = "Update Application Consents";
        }
        public Element applicantName => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ApplicantName"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/ComboBox[@AutomationId=\"ultraComboEditor\"]" +
            "/Edit"));

        public Element partyTypeName => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ThirdPartyName"),
            "/Pane[@AutomationId=\"rightPanel\"]" +
            "/ComboBox[@AutomationId=\"ultraComboEditor\"]" +
            "/Edit"));

        public Element nextBtn => new Element(FindElement(
                "pnlNextButton",
                attributeType: Defs.boLocatorAutomationId))
            .SetIsButtonFlag(true);
    }

    public class UpdateApplicantConsentsP1Data : PageData
    {
        public string applicantName { get; set; } = null;
    }

}
