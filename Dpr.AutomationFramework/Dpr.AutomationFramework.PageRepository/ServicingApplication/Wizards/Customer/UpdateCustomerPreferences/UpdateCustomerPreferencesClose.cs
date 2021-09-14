using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerPreferences
{
    public class UpdateCustomerPreferencesClose : GenericWizardClose
    {
        public UpdateCustomerPreferencesClose()
        {
            correspondingDataClass = new UpdateCustomerPreferencesCloseData().GetType();
            textName = "Update Customer Preferences Close";
        }
    }
    public class UpdateCustomerPreferencesCloseData : GenericWizardCloseData
    {
    }
}
