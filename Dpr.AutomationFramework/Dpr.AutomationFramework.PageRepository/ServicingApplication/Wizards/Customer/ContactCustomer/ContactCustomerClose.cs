using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.ContactCustomer
{
    public class ContactCustomerClose : GenericWizardClose
    {
        public ContactCustomerClose()
        {
            correspondingDataClass = new ContactCustomerCloseData().GetType();
            textName = "Contact Customer Close";
        }
    }
    public class ContactCustomerCloseData : GenericWizardCloseData
    {
    }
}
