using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerStatus.SetConfirmCustomerStatus
{
    public class SetConfirmCustomerStatusOpen : GenericWizardOpen
    {
        public SetConfirmCustomerStatusOpen()
        {
            pageLoadedElement = clickSetConfirmCustomerStatus;
            correspondingDataClass = new SetConfirmCustomerStatusOpenData().GetType();
            textName = "Set Confirm Customer Status Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.customer;
        public Element clickSetConfirmCustomerStatus => processActions.setConfirmCustomerStatus;
    }

    public class SetConfirmCustomerStatusOpenData : GenericWizardOpenData
    {
    }
}
