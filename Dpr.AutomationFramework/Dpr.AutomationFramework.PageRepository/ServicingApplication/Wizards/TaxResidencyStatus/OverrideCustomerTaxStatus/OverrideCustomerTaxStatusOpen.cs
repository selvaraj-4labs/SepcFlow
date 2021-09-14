using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateTaxResidencyStatus
{
    public class OverrideCustomerTaxStatusOpen : GenericWizardOpen
    {
        public OverrideCustomerTaxStatusOpen()
        {
            pageLoadedElement = clickCustomer;
            correspondingDataClass = new OverrideCustomerTaxStatusOpenData().GetType();
            textName = "Override Customer Tax Status Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;

        public Element clickUpdateCustomerPreferences => processActions.overrideCustomerTaxStatus;
    }

    public class OverrideCustomerTaxStatusOpenData : GenericWizardOpenData
    {
    }
}
