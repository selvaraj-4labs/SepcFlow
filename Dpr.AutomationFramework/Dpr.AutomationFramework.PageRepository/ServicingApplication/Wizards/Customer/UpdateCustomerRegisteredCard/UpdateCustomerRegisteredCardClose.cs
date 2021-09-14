using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerRegisteredCard
{
    public class UpdateCustomerRegisteredCardClose : GenericWizardClose
    {
        public UpdateCustomerRegisteredCardClose()
        {
            correspondingDataClass = new UpdateCustomerRegisteredCardCloseData().GetType();
            textName = "Update Customer Registered Card Close";
        }
    }
    public class UpdateCustomerRegisteredCardCloseData : GenericWizardCloseData
    {
    }
}
