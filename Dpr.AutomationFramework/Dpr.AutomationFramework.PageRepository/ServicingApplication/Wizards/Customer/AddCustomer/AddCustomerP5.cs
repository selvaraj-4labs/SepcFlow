using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.AddCustomer
{
    public class AddCustomerP5 : GenericFinalWizardPage
    {
        public AddCustomerP5()
        {
            correspondingDataClass = new AddCustomerP5Data().GetType();
            textName = "Add Customer Page 5";
        }
    }
    public class AddCustomerP5Data : GenericFinalWizardPageData
    {
    }
}
