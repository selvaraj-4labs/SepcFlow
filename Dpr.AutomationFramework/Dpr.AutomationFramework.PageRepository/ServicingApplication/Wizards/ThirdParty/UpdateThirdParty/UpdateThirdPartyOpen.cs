using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.UpdateThirdParty
{
    public class UpdateThirdPartyOpen : GenericWizardOpen
    {
        public UpdateThirdPartyOpen()
        {
            pageLoadedElement = clickUpdateThirdParty;
            correspondingDataClass = new UpdateThirdPartyOpenData().GetType();
            textName = "Update Third Party Open";
        }
        //public Element clickNewProcess => ribbon.newProcessMenu;
        //public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickUpdateThirdParty => processActions.updateThirdParty;
    }
    public class UpdateThirdPartyOpenData : GenericWizardOpenData
    {
    }
}
