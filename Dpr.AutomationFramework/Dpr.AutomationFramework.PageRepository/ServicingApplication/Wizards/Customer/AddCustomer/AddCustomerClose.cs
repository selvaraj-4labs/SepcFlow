using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.AddCustomer
{
    public class AddCustomerClose : GenericWizardClose
    {
        public AddCustomerClose()
        {
            correspondingDataClass = new AddCustomerCloseData().GetType();
            textName = "Add Customer Close";
        }
    }
    public class AddCustomerCloseData : GenericWizardCloseData
    {
    }
}
