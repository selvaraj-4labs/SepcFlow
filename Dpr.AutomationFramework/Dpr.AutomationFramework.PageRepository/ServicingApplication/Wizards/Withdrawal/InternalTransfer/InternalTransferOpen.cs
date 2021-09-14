using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.InternalTransfer
{
    public class InternalTransferOpen : GenericWizardOpen
    {
        public InternalTransferOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new InternalTransferOpenData().GetType();
            textName = "Internal Transfer Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountActions;
        public Element clickModifyAccountTags => processActions.internalTransfer;
    }

    public class InternalTransferOpenData : GenericWizardOpenData
    {
    }
}
