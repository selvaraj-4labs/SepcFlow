using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerPreferences
{
    public class UpdateCustomerPreferencesP3 : AppBasePage
    {
        public UpdateCustomerPreferencesP3()
        {
            pageLoadedElement = securityChbox;
            correspondingDataClass = new UpdateCustomerPreferencesP3Data().GetType();
            textName = "Update Customer Prefernces Page 3";
            pageCondition = new PageCondition(new Element(new ConditionList()
                .Add(new Condition("UpdateCustomerPreferencesP1", "editButtonGroup", "Edit"))
                ));
        }
        public Element securityChbox => new Element(FindElement("chkSecurity", attributeType: Defs.boLocatorAutomationId));
        public Element residentialChbox => new Element(FindElement("chkResidential", attributeType: Defs.boLocatorAutomationId));
        public Element correspondenceChbox => new Element(FindElement("chkCorrespondence", attributeType: Defs.boLocatorAutomationId));
        public Element effectiveDateBox => new Element(FindElement("txtEffectiveDate", attributeType: Defs.boLocatorAutomationId));
        public Element newAddressBox => new Element(FindElement("txtAddress", attributeType: Defs.boLocatorAutomationId));
        public Element remarksBox => new Element(FindElement("txtReasonForChange", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class UpdateCustomerPreferencesP3Data : PageData
    {
        public string security { get; set; } = null;
        public string residential { get; set; } = null;
        public string correspondence { get; set; } = null;
        public string effectiveDate { get; set; } = null;
        public string newAddress { get; set; } = null;
        public string remarks { get; set; } = "TestRemarks - Address Updated";
    }
}
