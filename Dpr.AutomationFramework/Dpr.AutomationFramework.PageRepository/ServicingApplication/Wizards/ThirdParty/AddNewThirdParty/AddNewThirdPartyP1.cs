using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.AddNewThirdParty
{
    public class AddNewThirdPartyP1 : AppBasePage
    {
        public AddNewThirdPartyP1()
        {
            pageLoadedElement = newOrExistingRbtn;
            correspondingDataClass = new AddNewThirdPartyP1Data().GetType();
            textName = "Add New Third Party Page 1";
        }

        public Element newOrExistingRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("New", FindElement("rbNewThirdParty", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Existing", FindElement("rbExisting", attributeType: Defs.boLocatorAutomationId)));

        public Section newSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "newOrExisting", "New"))));

        public Element isThirdPartyCompanyRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "osIsThirdPartyCompany"),
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "osIsThirdPartyCompany"),
                "/RadioButton[@Name=\"No\"]")));
        public Element isPanelCompanyRbtn => new Element(new RadioButton()
            .AddRadioButtonElement(Defs.radioButtonYes, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "osIsPanelCompany"),
                "/RadioButton[@Name=\"Yes\"]"))
            .AddRadioButtonElement(Defs.radioButtonNo, FindElement(new LocatorList()
                .Add(Defs.boLocatorAutomationId, "osIsPanelCompany"),
                "/RadioButton[@Name=\"No\"]")));

        public SectionEnd newBtnSectionEnd => new SectionEnd();

        public Section existingSection => new Section(new Element(
            new ConditionList()
            .Add(new Condition(className, "newOrExisting", "Existing"))));

        public Element individualOrCompanyRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Individual", FindElement("rbIndividual", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Company", FindElement("rbCompany", attributeType: Defs.boLocatorAutomationId)));
        public Element surnameBox => new Element(FindElement("txtSurname", attributeType: Defs.boLocatorAutomationId));
        public Element firstNameBox => new Element(FindElement("txtFirstName", attributeType: Defs.boLocatorAutomationId));
        public Element individualPostalCodeBox => new Element(FindElement("txtIndividualPostalCode", attributeType: Defs.boLocatorAutomationId));
        public Element nameBox => new Element(FindElement("txtName", attributeType: Defs.boLocatorAutomationId));
        public Element registrationNumberBox => new Element(FindElement("txtRegistrationNumber", attributeType: Defs.boLocatorAutomationId));
        public Element companyPostalCodeBox => new Element(FindElement("txtCompanyPostalCode", attributeType: Defs.boLocatorAutomationId));
        public Element searchBtn => new Element(FindElement("btnSearch", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public SectionEnd existingSectionEnd => new SectionEnd();

        
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

    }

    public class AddNewThirdPartyP1Data : PageData
    {
        public string newOrExisting { get; set; } = "New";

        public string isThirdPartyCompany { get; set; } = Defs.radioButtonNo;

        public string isPanelCompany { get; set; } = Defs.radioButtonNo;
    }
}
