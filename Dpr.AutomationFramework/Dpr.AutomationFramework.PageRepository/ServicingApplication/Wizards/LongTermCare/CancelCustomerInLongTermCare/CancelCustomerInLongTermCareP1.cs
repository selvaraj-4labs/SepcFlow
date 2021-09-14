using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CancelCustomerInLongTermCare
{
    public class CancelCustomerInLongTermCareP1 : AppBasePage
    {
        public CancelCustomerInLongTermCareP1()
        {
            pageLoadedElement = customerNumberBox;
            correspondingDataClass = new CancelCustomerInLongTermCareP1Data().GetType();
            textName = "Cancel Customer In Long Term Care Page 1";
        }

        public Element customerNumberBox => new Element(FindElement("txtCustomerNumber", attributeType: Defs.boLocatorAutomationId));
        public Element customerNameBox => new Element(FindElement("txtCustomerName", attributeType: Defs.boLocatorAutomationId));
        public Element longTermCareNotificationDateBox => new Element(FindElement("dtLongTermCareNotificationDate", attributeType: Defs.boLocatorAutomationId));
        public Element careHomeNameBox => new Element(FindElement("txtCareHomeName", attributeType: Defs.boLocatorAutomationId));
        public Element careHomeAddressBox => new Element(FindElement("txtCareHomeAddress", attributeType: Defs.boLocatorAutomationId));
        public Element confirmationDateBox => new Element(FindElement("dtLongTermCareConfirmationDate", attributeType: Defs.boLocatorAutomationId));
        public Element confirmationTypeBox => new Element(FindElement("txtLongTermCareConfirmationType", attributeType: Defs.boLocatorAutomationId));
        public Element cancelConfirmationChbox => new Element(FindElement("chkCancelConfirmationCustomerLongTermCare", attributeType: Defs.boLocatorAutomationId));
        public Section cancelConfirmationSection => new Section(new Element(new ConditionList()
            .Add(new Condition(cancelConfirmationChbox.locator, Defs.checkBoxSelected))));
        public Element reasonLookup => new Element(FindElement("ceReason", attributeType: Defs.boLocatorAutomationId));
        public SectionEnd cancelConfirmationSectionEnd => new SectionEnd();
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CancelCustomerInLongTermCareP1Data : PageData
    {
        public string customerNumber { get; set; } = null;
        public string customerName { get; set; } = null;
        public string longTermCareNotification { get; set; } = null;
        public string careHomeName { get; set; } = null;
        public string careHomeAddress { get; set; } = null;
        public string confirmationDate { get; set; } = null;
        public string confirmationType { get; set; } = null;
        public string cancelConfirmation { get; set; } = Defs.checkBoxSelected;
        public string reason { get; set; } = "Updated in Error";
        public string remarks { get; set; } = "TestRemarks";
    }
}
