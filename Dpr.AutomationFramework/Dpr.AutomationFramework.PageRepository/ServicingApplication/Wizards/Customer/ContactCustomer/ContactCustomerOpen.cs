using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.ContactCustomer
{
    public class ContactCustomerOpen : GenericWizardOpen
    {
        public ContactCustomerOpen()
        {
            pageLoadedElement = clickAddCustomer;
            correspondingDataClass = new ContactCustomerOpenData().GetType();
            textName = "Add Customer Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickCustomerMenu => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickAddCustomer => processActions.contactCustomer;
    }
    public class ContactCustomerOpenData : GenericWizardOpenData
    {
    }
}
