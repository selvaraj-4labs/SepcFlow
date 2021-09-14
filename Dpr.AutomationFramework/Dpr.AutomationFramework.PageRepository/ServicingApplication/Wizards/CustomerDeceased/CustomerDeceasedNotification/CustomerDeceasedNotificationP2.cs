using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.CustomerDeceasedNotification
{
    public class CustomerDeceasedNotificationP2 : GenericFinalWizardPage
    {
        public CustomerDeceasedNotificationP2()
        {
            correspondingDataClass = new CustomerDeceasedNotificationP2Data().GetType();
            textName = "Customer Deceased Notification Page 2";
        }
    }

    public class CustomerDeceasedNotificationP2Data : GenericFinalWizardPageData
    { 
    }
}
