using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.CustomerDeceasedNotification
{
    public class CustomerDeceasedNotificationClose : GenericWizardClose
    {
        public CustomerDeceasedNotificationClose()
        {
            correspondingDataClass = new CustomerDeceasedNotificationCloseData().GetType();
            textName = "Customer Deceased Notification Close";
        }
    }

    public class CustomerDeceasedNotificationCloseData : GenericWizardCloseData
    {
    }
}
