using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification
{
    public class CustomerInLongTermCareNotificationClose : GenericWizardClose
    {
        public CustomerInLongTermCareNotificationClose()
        {
            correspondingDataClass = new CustomerInLongTermCareNotificationCloseData().GetType();
            textName = "Customer In Long Term Care Notification Close";
        }
    }
    public class CustomerInLongTermCareNotificationCloseData : GenericWizardCloseData
    {
    }
}
