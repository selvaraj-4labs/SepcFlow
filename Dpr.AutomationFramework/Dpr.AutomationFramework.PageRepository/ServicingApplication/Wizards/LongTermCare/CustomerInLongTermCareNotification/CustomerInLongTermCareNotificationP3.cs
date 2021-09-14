using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification
{
    public class CustomerInLongTermCareNotificationP3 : AppBasePage
    {
        public CustomerInLongTermCareNotificationP3()
        {
            pageLoadedElement = companyNameBox;
            correspondingDataClass = new CustomerInLongTermCareNotificationP3Data().GetType();
            textName = "Customer In Long Term Care Notification Page 3";
        }
        public Element companyNameBox => new Element(FindElement("txtCompany", attributeType: Defs.boLocatorAutomationId));
        public Element propertyNumberBox => new Element(FindElement("teAddressLine", attributeType: Defs.boLocatorAutomationId));
        public Element postcodeBox => new Element(FindElement("tePostCodeSrch", attributeType: Defs.boLocatorAutomationId));
        public Element searchBtn => new Element(FindElement("btnAddressSearch", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }

    public class CustomerInLongTermCareNotificationP3Data : PageData
    {
        public string companyName { get; set; } = "TestCareHome";
        public string propertyNumber { get; set; } = "11";
        public string postcode { get; set; } = "DA1 1TX";
    }
}
