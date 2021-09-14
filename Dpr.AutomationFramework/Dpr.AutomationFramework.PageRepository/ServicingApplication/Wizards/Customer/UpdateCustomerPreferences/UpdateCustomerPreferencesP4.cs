using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerPreferences
{
    public class UpdateCustomerPreferencesP4 : AppBasePage
    {
        public UpdateCustomerPreferencesP4()
        {
            pageLoadedElement = telephoneMarketingChbox;
            correspondingDataClass = new UpdateCustomerPreferencesP4Data().GetType();
            textName = "Update Customer Preferences Page 4";
        }
        public Element telephoneMarketingChbox => new Element(FindElement("cbTelMarketing", attributeType: Defs.boLocatorAutomationId));
        public Element emailMarketingChbox => new Element(FindElement("cbEMailMarketing", attributeType: Defs.boLocatorAutomationId));
        public Element postMarketingChbox => new Element(FindElement("cbMailMarketing", attributeType: Defs.boLocatorAutomationId));
        public Element textMarketingChbox => new Element(FindElement("cbTextMarketing", attributeType: Defs.boLocatorAutomationId));
        public Element disabilityTypeLookup => new Element(FindElement("cboDisabilityType", attributeType: Defs.boLocatorAutomationId));
        public Element documentTypeLookup => new Element(FindElement("cboDocumentType", attributeType: Defs.boLocatorAutomationId));

        public Element communicationDeliveryLookup => new Element(FindElement("cboCommDelPref", attributeType: Defs.boLocatorAutomationId));
        public Element separateDocumentReqChbox => new Element(FindElement("cbSeparateDocReq", attributeType: Defs.boLocatorAutomationId));
        public Element mailHoldChbox => new Element(FindElement("cbMailHold", attributeType: Defs.boLocatorAutomationId));
        public Element mailHoldReasonBox => new Element(FindElement("txtMailHoldReason", attributeType: Defs.boLocatorAutomationId),
            new ConditionList()
            .Add(new Condition(mailHoldChbox.locator, Defs.checkBoxSelected)));
        public Element smsNotificationLookup => new Element(FindElement("cboSMSNotification", attributeType: Defs.boLocatorAutomationId));
        public Element paperlessAccountStatementsChbox => new Element(FindElement("cbPaperlessAccountStatements", attributeType: Defs.boLocatorAutomationId));
        public Element paperlessRegulatoryStatementsChbox => new Element(FindElement("cbPaperlessRegulatoryStatements", attributeType: Defs.boLocatorAutomationId));
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));

        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class UpdateCustomerPreferencesP4Data : PageData
    {
        public string telephoneMarketing { get; set; } = null;
        public string emailMarketing { get; set; } = null;
        public string postMarketing { get; set; } = null;
        public string textMarketing { get; set; } = null;
        public string disabilityType { get; set; } = null;
        public string documentType { get; set; } = null;
        public string communicationDelivery { get; set; } = null;
        public string separateDocumentReq { get; set; } = null;
        public string mailHold { get; set; } = null;
        public string mailHoldReason { get; set; } = null;
        public string smsNotification { get; set; } = null;
        public string paperlessAccountStatements { get; set; } = null;
        public string remarks { get; set; } = "TestRemarks";
    }
}
