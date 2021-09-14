using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.CustomerDeduplication
{
    public class CustomerDeduplicationClose : GenericWizardClose
    {
        public CustomerDeduplicationClose()
        {
            correspondingDataClass = new CustomerDeduplicationCloseData().GetType();
            textName = "Customer Deduplication Close";
        }
    }
    public class CustomerDeduplicationCloseData : GenericWizardCloseData
    {
    }
}
