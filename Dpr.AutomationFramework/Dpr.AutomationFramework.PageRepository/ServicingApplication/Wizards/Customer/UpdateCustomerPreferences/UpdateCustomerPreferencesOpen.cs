using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdateCustomerPreferences
{
    public class UpdateCustomerPreferencesOpen : GenericWizardOpen
    {
        public UpdateCustomerPreferencesOpen()
        {
            pageLoadedElement = clickUpdateCustomerPreferences;
            correspondingDataClass = new UpdateCustomerPreferencesOpenData().GetType();
            textName = "Update Customer Preferences Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickUpdateCustomerPreferences => processActions.updateCustomerPreferences;
    }
    public class UpdateCustomerPreferencesOpenData : GenericWizardOpenData
    {
    }
}
