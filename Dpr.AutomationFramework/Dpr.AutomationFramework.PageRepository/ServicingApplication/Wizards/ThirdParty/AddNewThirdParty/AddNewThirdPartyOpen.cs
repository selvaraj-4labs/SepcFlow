using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.AddNewThirdParty
{
    public class AddNewThirdPartyOpen : GenericWizardOpen
    {
        public AddNewThirdPartyOpen()
        {
            pageLoadedElement = clickAddNewThirdParty;
            correspondingDataClass = new AddNewThirdPartyOpenData().GetType();
            textName = "Add New Third Party Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickAddNewThirdParty => processActions.addNewThirdParty;
    }

    public class AddNewThirdPartyOpenData : GenericWizardOpenData
    {
    }
}
