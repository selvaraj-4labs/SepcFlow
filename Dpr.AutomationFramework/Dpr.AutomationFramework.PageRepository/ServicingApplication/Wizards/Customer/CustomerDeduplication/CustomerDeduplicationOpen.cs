using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.CustomerDeduplication
{
    public class CustomerDeduplicationOpen : GenericWizardOpen
    {
        public CustomerDeduplicationOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new CustomerDeduplicationOpenData().GetType();
            textName = "Customer Deduplication Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.customer;
        public Element clickCustomerDeduplication => processActions.customerDeduplication;
    }
    public class CustomerDeduplicationOpenData : GenericWizardOpenData
    {
    }
}
