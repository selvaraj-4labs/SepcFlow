using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.CancelRegularDeposit
{
    public class CancelRegularDepositOpen : GenericWizardOpen
    {
        public CancelRegularDepositOpen()
        {
            pageLoadedElement = clickCancelRegularDeposit;
            correspondingDataClass = new CancelRegularDepositOpenData().GetType();
            textName = "Cancel Regular Deposit Open";
        }


        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountActions;
        public Element clickCancelRegularDeposit => processActions.cancelRegularDeposit;
    }

    public class CancelRegularDepositOpenData : GenericWizardOpenData
    {
    }
}
