using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification
{
    public class CustomerInLongTermCareNotificationP7 : GenericFinalWizardPage
    {
        public CustomerInLongTermCareNotificationP7()
        {
            correspondingDataClass = new CustomerInLongTermCareNotificationP7Data().GetType();
            textName = "Customer In Long Term Care Notification Page 7";
        }
    }
    public class CustomerInLongTermCareNotificationP7Data : GenericFinalWizardPageData
    {
    }
}
