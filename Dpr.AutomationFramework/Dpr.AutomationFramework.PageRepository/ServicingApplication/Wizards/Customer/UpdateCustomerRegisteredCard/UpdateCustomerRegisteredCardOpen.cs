using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerRegisteredCard
{
    public class UpdateCustomerRegisteredCardOpen : GenericWizardOpen
    {
        public UpdateCustomerRegisteredCardOpen()
        {
            pageLoadedElement = clickUpdateCustomerPreferences;
            correspondingDataClass = new UpdateCustomerRegisteredCardOpenData().GetType();
            textName = "Update Customer Registered Card Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.repayments;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.repayments;
        public Element clickUpdateCustomerPreferences => processActions.updateCustomerRegisteredCard;
    }

    public class UpdateCustomerRegisteredCardOpenData : GenericWizardOpenData
    {
    }
}
