using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.AddCustomer
{
    public class AddCustomerOpen : GenericWizardOpen
    {
        public AddCustomerOpen()
        {
            pageLoadedElement = clickAddCustomer;
            correspondingDataClass = new AddCustomerOpenData().GetType();
            textName = "Add Customer Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickCustomerMenu => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickAddCustomer => processActions.addCustomer;
    }
    public class AddCustomerOpenData : GenericWizardOpenData
    {
    }
}
