using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.CustomerDeduplication
{
    public class CustomerDeduplicationP2 : AppBasePage
    {
        public CustomerDeduplicationP2()
        {
            pageLoadedElement = primaryCustomerNameBox;
            correspondingDataClass = new CustomerDeduplicationP2Data().GetType();
            textName = "Customer Deduplication Page 2";
        }
        public Element primaryCustomerNameBox => new Element(FindElement("txtPrimaryCustomerName", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class CustomerDeduplicationP2Data : PageData
    {
    }
}
