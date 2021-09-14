using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.CustomerDeceasedNotification
{
    public class CustomerDeceasedNotificationOpen : GenericWizardOpen
    {
        public CustomerDeceasedNotificationOpen()
        {
            pageLoadedElement = clickAccountReview;
            correspondingDataClass = new CustomerDeceasedNotificationOpenData().GetType();
            textName = "Customer Decease Notification Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickAccountReview => processActions.customerDeceasedNotification;
    }

    public class CustomerDeceasedNotificationOpenData : GenericWizardOpenData
    {
    }
}
