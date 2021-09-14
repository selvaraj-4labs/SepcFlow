using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.BackOfficeApplication.Wizards.AmendAccountSettingsWizard
{
    public class AmendAccountSettingsP1 : BOWizardBasePage
    {

        public AmendAccountSettingsP1()
        {
            pageLoadedElement = nextBtn;
            correspondingDataClass = new AmendAccontSettingsP1Data().GetType();
            textName = "Amend Account Setting Page 1";
            windowTitle = "Account Settings Wizard";
        }
        public Element anonymisationStatus => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboAnonymizationStatus"),
            "/Edit"));
        public Element notesBox => new Element(FindElement("txtNotes", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AmendAccontSettingsP1Data : PageData
    {
        public string anonymisationStatus { get; set; } = "Anonymize";
        public string notes { get; set; } = "Automation";
    }
}
