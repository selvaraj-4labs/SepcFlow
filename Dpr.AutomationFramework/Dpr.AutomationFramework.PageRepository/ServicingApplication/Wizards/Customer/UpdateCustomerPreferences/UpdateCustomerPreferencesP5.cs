using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerPreferences
{
    public class UpdateCustomerPreferencesP5 : AppBasePage
    {
        public UpdateCustomerPreferencesP5()
        {
            pageLoadedElement = consentTypeButtonGroup;
            correspondingDataClass = new UpdateCustomerPreferencesP5Data().GetType();
            textName = "Update Customer Preferences Page 5";
        }

        // CHECK IF THIS IS THE CORRECT ORDER WHEN RUNNING FOR FIRST TIME.
        /*.AddButtonElement("Allow Any Solicitation", FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0"), "/DataItem[@Name = 'Delete']"))*/
        public Element consentTypeButtonGroup => new Element(new ButtonGroup()
            .AddButtonElement("Allow Phone Solicitation", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0"), 
                    "/DataItem[@Name=\"Allow Phone Solicitation\"]" +
                    "/CheckBox[@Name=\"Delete\"]"))
            .AddButtonElement("Allow Direct Mail Solicitation", FindElement(new LocatorList()
               .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0"), 
                    "/DataItem[@Name=\"Allow Direct Mail Solicitation\"]" +
                    "/CheckBox[@Name=\"Delete\"]"))
            .AddButtonElement("Allow SMS Solicitation", FindElement(new LocatorList()
                 .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0"), 
                    "/DataItem[@Name=\"AllowSMSSolicitation\"]" +
                    "/CheckBox[@Name=\"Delete\"]"))
            .AddButtonElement("Allow Email Marketing", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "ColScrollRegion: 0, RowScrollRegion: 0"), 
                    "/DataItem[@Name=\"AllowEmailSolicitation\"]" +
                    "/CheckBox[@Name=\"Delete\"]")));

        public Element updateButtonGroup => new Element(new ButtonGroup()
            .AddButtonElement("Update", FindElement("btnUpdateEnable", attributeType: Defs.boLocatorAutomationId))
            .AddButtonElement("No Update", FindElement("WizardTitle", attributeType: Defs.boLocatorAutomationId)));

        public Element addNewButtonGroup => new Element(new ButtonGroup()
            .AddButtonElement("Add New", FindElement("btnAddEnable", attributeType: Defs.boLocatorAutomationId))
            .AddButtonElement("No New", FindElement("WizardTitle", attributeType: Defs.boLocatorAutomationId)));

        #region 'Update Customer Consent' Section
        public Section updateCustomerConsentSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "updateButtonGroup", "Edit"))));

        public Element consentTypeBox => new Element(FindElement("txtUpdateConsentType", attributeType: Defs.boLocatorAutomationId));
        public Element updateConsentProvidedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbUpdateConsentProvided"),
                "/RadioButton[@Name=\"Yes\"][starts-with(@AutomationId,\"rbOption\")]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbUpdateConsentProvided"),
                "/RadioButton[@Name=\"No\"][starts-with(@AutomationId,\"rbOption\")]")));
        public Element consentProvidedByBox => new Element(FindElement("textUpdateConsentProvidedBy", attributeType: Defs.boLocatorAutomationId));
        public Element consentCreateBox => new Element(FindElement("dtUpdateConsentCreated", attributeType: Defs.boLocatorAutomationId));
        public Element updateConsentValidationNotesBox => new Element(FindElement("txtUpdateConsentValidationNotes", attributeType: Defs.boLocatorAutomationId));
        public Element updateConsentBtn => new Element(FindElement("btnUpdate", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

        public SectionEnd updateCustomerConsentSectionEnd => new SectionEnd();
        #endregion

        #region 'Add New Customer Conesent' Section
        public Section addNewCustomerConsentSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "addNewButtonGroup", "Add New"))));

        public Element consentTypeLookup => new Element(FindElement("cboAddConsentType", attributeType: Defs.boLocatorAutomationId));
        public Element addNewConsentProvidedRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Yes", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbUpdateConsentProvided"),
                "/RadioButton[@Name=\"Yes\"][starts-with(@AutomationId,\"rbOption\")]"))
            .AddRadioButtonElement("No", FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "rbUpdateConsentProvided"),
                "/RadioButton[@Name=\"No\"][starts-with(@AutomationId,\"rbOption\")]")));
        public Element addNewConsentProvidedByLookup => new Element(FindElement("cboAddConsentProvidedBy", attributeType: Defs.boLocatorAutomationId));
        public Element addNewConsentValidationNotesBox => new Element(FindElement("txtUpdateConsentValidationNotes", attributeType: Defs.boLocatorAutomationId));
        public Element addNewConsentBtn => new Element(FindElement("ultraButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

        public SectionEnd addNewCustomerConsentSectionEnd => new SectionEnd();
        #endregion

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class UpdateCustomerPreferencesP5Data : PageData
    {
        public string consentTypeButtonGroup { get; set; } = null;
        public string updateButtonGroup { get; set; } = "No Update";
        public string addNewButtonGroup { get; set; } = "No New";

        public string updateConsentProvided { get; set; } = null;
        public string updateConsentValidationNotes { get; set; } = "TestConsentValidationNotes";

        public string consentType { get; set; } = null;
        public string addNewConsentProvided { get; set; } = null;
        public string addNewConsentProvidedBy { get; set; } = "905928506-Premium Bank";
        public string addNewconsentValidationNotes { get; set; } = "TestConsentValidationNotes";
    }
}
