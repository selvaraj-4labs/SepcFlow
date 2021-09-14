using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.CustomerInLongTermCareNotification
{
    public class CustomerInLongTermCareNotificationOpen : GenericWizardOpen
    {
        public CustomerInLongTermCareNotificationOpen()
        {
            pageLoadedElement = clickCustomerInLongTermCareNotification;
            correspondingDataClass = new CustomerInLongTermCareNotificationOpenData().GetType();
            textName = "Customer In Long Term Care Notification Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickCustomerInLongTermCareNotification => processActions.customerInLongTermCareNotification;
    }
    public class CustomerInLongTermCareNotificationOpenData : GenericWizardOpenData
    {
    }
}
