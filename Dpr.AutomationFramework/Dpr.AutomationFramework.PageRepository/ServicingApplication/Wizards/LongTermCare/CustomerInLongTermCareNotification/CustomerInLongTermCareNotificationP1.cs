using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification
{
    public class CustomerInLongTermCareNotificationP1 : AppBasePage
    {
        public CustomerInLongTermCareNotificationP1()
        {
            pageLoadedElement = customerNumberBox;
            correspondingDataClass = new CustomerInLongTermCareNotificationP1Data().GetType();
            textName = "Customer In Long Term Care Notification Page 1";
        }
        public Element customerNumberBox => new Element(FindElement("txtCustomerNumber", attributeType: Defs.boLocatorAutomationId));
        public Element customerNameBox => new Element(FindElement("txtCustomerName", attributeType: Defs.boLocatorAutomationId));
        public Element notificationDateBox => new Element(FindElement("dtNotificationDate", attributeType: Defs.boLocatorAutomationId));
        public Element remarksBox => new Element(FindElement("txtRemarks", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CustomerInLongTermCareNotificationP1Data : PageData
    {
        public string customerNumber { get; set; } = null;
        public string customerName { get; set; } = null;
        public string notificationDateBox { get; set; } = null;
        public string remarks { get; set; } = "TestRemarks";
    }
}
