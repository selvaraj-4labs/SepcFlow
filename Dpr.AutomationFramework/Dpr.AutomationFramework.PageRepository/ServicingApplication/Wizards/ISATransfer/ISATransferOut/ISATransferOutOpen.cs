using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;


namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.ISATransfer.ISATransferOut
{
    public class ISATransferOutOpen : GenericWizardOpen
    {
        public ISATransferOutOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new ISATransferOutOpenData().GetType();
            textName = "ISA Transfer Out Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountActions;
        public Element clickIsaTransferOut => processActions.isaTransferOut;
    }

    public class ISATransferOutOpenData : GenericWizardOpenData
    {
    }
}
