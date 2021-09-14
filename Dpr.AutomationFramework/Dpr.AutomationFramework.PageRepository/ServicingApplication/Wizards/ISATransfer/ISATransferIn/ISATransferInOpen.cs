using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferIn
{
    public class ISATransferInOpen : GenericWizardOpen
    {
        public ISATransferInOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new ISATransferInOpenData().GetType();
            textName = "ISA Transfer In Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountActions;
        public Element clickIsaTransferIn => processActions.isaTransferIn;
    }

    public class ISATransferInOpenData : GenericWizardOpenData
    {
    }
}
