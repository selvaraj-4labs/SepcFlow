using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerPreferences
{
    public class UpdateCustomerPreferencesP6 : GenericFinalWizardPage
    {
        public UpdateCustomerPreferencesP6()
        {
            correspondingDataClass = new UpdateCustomerPreferencesP6Data().GetType();
            textName = "Update Customer Preferences Page 6";
        }
    }
    public class UpdateCustomerPreferencesP6Data : GenericFinalWizardPageData
    {
    }
}
