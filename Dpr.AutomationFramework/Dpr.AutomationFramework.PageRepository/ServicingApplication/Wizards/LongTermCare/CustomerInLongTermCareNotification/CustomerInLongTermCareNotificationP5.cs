using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification
{
    public class CustomerInLongTermCareNotificationP5 : AppBasePage
    {
        public CustomerInLongTermCareNotificationP5()
        {
            pageLoadedElement = workPhone;
            correspondingDataClass = new CustomerInLongTermCareNotificationP5Data().GetType();
            textName = "Customer In Long Term Care Notification Page 5";
        }
        public Element workPhone=> new Element(FindElement("txtPhoneWork", attributeType: Defs.boLocatorAutomationId));
        public Element homePhone=> new Element(FindElement("txtPhoneHome", attributeType: Defs.boLocatorAutomationId));
        public Element mobilePhone=> new Element(FindElement("txtMobile", attributeType: Defs.boLocatorAutomationId));
        public Element email => new Element(FindElement("txtEmail", attributeType: Defs.boLocatorAutomationId));
        public Element contactPreference => new Element(FindElement(new LocatorList()
            .Add(Defs.boLocatorAutomationId, "cboContactPreference"), 
            "/Edit"));
        public Element contactConstraints=> new Element(FindElement("txtContactConstraints", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CustomerInLongTermCareNotificationP5Data : PageData
    {
        public string workPhone { get; set; } = null;
        public string homePhone { get; set; } = null;
        public string mobilePhone { get; set; } = "0177000000";
        public string email { get; set; } = null;
        public string contactPreference { get; set; } = "Mobile Phone";
        public string contactConstraints { get; set; } = null;
    }
}
