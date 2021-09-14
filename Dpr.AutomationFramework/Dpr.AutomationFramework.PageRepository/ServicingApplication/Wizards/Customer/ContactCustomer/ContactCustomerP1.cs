using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.ContactCustomer
{
    public class ContactCustomerP1 : AppBasePage
    {
        public ContactCustomerP1()
        {
            pageLoadedElement = titleLookup;
            correspondingDataClass = new ContactCustomerP1Data().GetType();
            textName = "Contact Customer Page 1";
        }

        public Element titleLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "templateTitleComboEditor"), 
            "/Edit"));
        public Element messageBox => new Element(FindElement("messageTextEditor", attributeType: Defs.boLocatorAutomationId));

        public Element emailRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Existing", FindElement("emailExistingRadioButton", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("New", FindElement("emailNewRadioButton", attributeType: Defs.boLocatorAutomationId)));

        public Element newEmailBox => new Element(FindElement("emailNewTextEditor", attributeType: Defs.boLocatorAutomationId), new ConditionList()
            .Add(new Condition(className, "email", "New")));

        public Element smsRbtn => new Element(new RadioButton()
            .AddRadioButtonElement("Existing", FindElement("smsExistingRadioButton", attributeType: Defs.boLocatorAutomationId))
            .AddRadioButtonElement("New", FindElement("smsNewRadioButton", attributeType: Defs.boLocatorAutomationId)));

        public Element newSmsBox => new Element(FindElement("smsNewTextEditor", attributeType: Defs.boLocatorAutomationId), new ConditionList()
            .Add(new Condition(className, "sms", "New")));

        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element confirmBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class ContactCustomerP1Data : PageData
    {
        public string title { get; set; } = "Debit Payment Error Email";
        public string message { get; set; } = null;
        public string email { get; set; } = "Existing";
        public string newEmail { get; set; } = null;
        public string sms { get; set; } = null;
        public string newSms { get; set; } = null;
        public string remarks { get; set; } = "TestRemarks";
    }
}
