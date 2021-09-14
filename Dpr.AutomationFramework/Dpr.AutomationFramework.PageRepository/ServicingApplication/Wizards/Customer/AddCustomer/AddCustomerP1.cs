using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;
using OpenQA.Selenium;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.AddCustomer
{
    public class AddCustomerP1 : AppBasePage
    {
        public AddCustomerP1()
        {
            pageLoadedElement = typeLookup;
            correspondingDataClass = new AddCustomerP1Data().GetType();
            textName = "Add Customer Page 1";
        }

        public Element typeLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cePartyType"),
            "/Edit"));
        public Element effectiveDateBox => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "dtEffectiveFrom"),
            "/Edit"));
        public Element newExistingRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("New", FindElement("rbNewCustomer", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("Existing", FindElement("rbExistingCustomer", attributeType: Defs.boLocatorAutomationId)));

        public Section existingCustomerSection => new Section(new Element(new ConditionList()
            .Add(new Condition(className, "newExisting", "Existing"))));

        public Element customerNoBox => new Element(FindElement("txtCustomerNo", attributeType: Defs.boLocatorAutomationId));
        public Element surnameBox => new Element(FindElement("txtSurname", attributeType: Defs.boLocatorAutomationId));
        public Element postalCodeBox => new Element(FindElement("txtPostalCode", attributeType: Defs.boLocatorAutomationId));
        public Element searchBtn => new Element(FindElement("btnSearch", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);

        public SectionEnd existingCustomerSectionEnd => new SectionEnd();

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddCustomerP1Data : PageData
    {
        private string _effectiveDate = null;

        public string type { get; set; } = "Customer";
        public string effectiveDate
        {
            get
            {
                if (_effectiveDate == null)
                {
                    return null;
                }
                else
                {
                    return 
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        Keys.Backspace +
                        _effectiveDate.Replace("/", "");
                }
            }
            set
            {
                _effectiveDate = value;

            }
        }
        public string newExisting { get; set; } = "New";
        public string customerNo { get; set; } = null;
        public string surname { get; set; } = null;
        public string postalCode { get; set; } = null;
    }
}
