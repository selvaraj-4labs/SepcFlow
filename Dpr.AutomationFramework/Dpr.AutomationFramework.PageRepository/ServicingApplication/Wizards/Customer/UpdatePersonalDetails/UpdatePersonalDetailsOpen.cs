using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.UpdatePersonalDetails
{
    public class UpdatePersonalDetailsOpen : GenericWizardOpen
    {
        public UpdatePersonalDetailsOpen()
        {
            pageLoadedElement = clickUpdatePersonalDetails;
            correspondingDataClass = new UpdatePersonalDetailsOpenData().GetType();
            textName = "Update Personal Details Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickUpdatePersonalDetails => processActions.updatePersonalDetails;
    }
    public class UpdatePersonalDetailsOpenData : GenericWizardOpenData
    {
    }
}
