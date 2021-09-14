using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Base;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.DefaultData;
using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.Definitions;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.CustomerDeduplication
{
    public class CustomerDeduplicationP1 : AppBasePage
    {
        public CustomerDeduplicationP1()
        {
            pageLoadedElement = primaryCustomerNo;
            correspondingDataClass = new CustomerDeduplicationP1Data().GetType();
            textName = "Customer Deduplication Page 1";
        }
        public Element primaryCustomerNo => new Element(FindElement("txtPrimaryCustomerNumber", attributeType: Defs.boLocatorAutomationId));
        public Element secondaryCustomerNo => new Element(FindElement("txtSecondaryCustomerNumber", attributeType: Defs.boLocatorAutomationId));
        public Element nextBtn => new Element(FindElement("pnlNextButton", attributeType: Defs.boLocatorAutomationId)).SetIsButtonFlag(true);
    }
    public class CustomerDeduplicationP1Data : PageData
    {
        public string primaryCustomerNo { get; set; }
        public string secondaryCustomerNo { get; set; }
    }
}
