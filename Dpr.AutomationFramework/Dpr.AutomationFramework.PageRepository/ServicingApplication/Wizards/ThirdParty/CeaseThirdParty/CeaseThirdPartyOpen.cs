using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ThirdParty.CeaseThirdParty
{
    public class CeaseThirdPartyOpen : GenericWizardOpen
    {
        public CeaseThirdPartyOpen()
        {
            pageLoadedElement = clickCeaseThirdParty;
            correspondingDataClass = new CeaseThirdPartyOpenData().GetType();
            textName = "Cease Third Party Open";
        }
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickCustomer => processActions.customer;
        public Element clickCeaseThirdParty => processActions.ceaseThirdParty;
    }
    public class CeaseThirdPartyOpenData : GenericWizardOpenData
    {
    }
}
