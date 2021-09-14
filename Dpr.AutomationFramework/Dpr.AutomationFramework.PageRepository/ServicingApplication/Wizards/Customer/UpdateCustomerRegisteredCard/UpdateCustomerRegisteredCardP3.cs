using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerRegisteredCard
{
    public class UpdateCustomerRegisteredCardP3 : GenericFinalWizardPage
    {
        public UpdateCustomerRegisteredCardP3()
        {
            correspondingDataClass = new UpdateCustomerRegisteredCardP3Data().GetType();
            textName = "Update Customer Registered Card P3 ";
        }
    }

    public class UpdateCustomerRegisteredCardP3Data : GenericFinalWizardPageData
    {
    }
}
