using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.AddCustomer
{
    public class AddCustomerP4 : AppBasePage
    {
        public AddCustomerP4()
        {
            pageLoadedElement = workPhoneBox;
            correspondingDataClass = new AddCustomerP4Data().GetType();
            textName = "Add Customer Page 4";
        }

        public Element workPhoneBox => new Element(FindElement("txtPhoneWork", attributeType: Defs.boLocatorAutomationId));
        public Element homePhoneBox => new Element(FindElement("txtPhoneHome", attributeType: Defs.boLocatorAutomationId));
        public Element mobilePhoneBox => new Element(FindElement("txtMobile", attributeType: Defs.boLocatorAutomationId));
        public Element emailBox => new Element(FindElement("txtEmail", attributeType: Defs.boLocatorAutomationId));
        public Element contactPreferenceLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboContactPreference"),
            "/Edit"));
        public Element contactConstraintsBox => new Element(FindElement("txtContactConstraints", attributeType: Defs.boLocatorAutomationId));

        public Element telephoneMarketingChbox => new Element(FindElement("cbTelMarketing", attributeType: Defs.boLocatorAutomationId));
        public Element emailMarketingChbox => new Element(FindElement("cbEMailMarketing", attributeType: Defs.boLocatorAutomationId));
        public Element postMarketingChbox => new Element(FindElement("cbMailMarketing", attributeType: Defs.boLocatorAutomationId));
        public Element textMarketingChbox => new Element(FindElement("cbTextMarketing", attributeType: Defs.boLocatorAutomationId));
        public Element commDeliveryPreferencesLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboContactPrefeceCommDelPrefrence"),
            "/Edit"));
        public Element callOutPasswordBox => new Element(FindElement("txtPasswordEdit", attributeType: Defs.boLocatorAutomationId));
        public Element disabilityTypeLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ceDisabilityTypeEdit"),
            "/Edit"));
        public Element documentTypeLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ceDocumentFormatEdit"),
            "/Edit"));
        public Element smsNotificationForLookup => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "ceSMSNotification"),
            "/Edit"));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class AddCustomerP4Data : PageData
    {
        public string workPhone { get; set; } = null;
        public string homePhone { get; set; } = null;
        public string mobilePhone { get; set; } = "0177000000";
        public string email { get; set; } = null;
        public string contactPreference { get; set; } = "Mobile Phone";
        public string contactConstraints { get; set; } = null;
        public string telephoneMarketing { get; set; } = null;
        public string emailMarketing { get; set; } = null;
        public string postMarketing { get; set; } = null;
        public string textMarketing { get; set; } = null;
        public string commDeliveryPreferences { get; set; } = null;
        public string callOutPassword { get; set; } = null;
        public string disabilityType { get; set; } = null;
        public string documentType { get; set; } = null;
        public string smsNotificationFor { get; set; } = null;
    }
}
