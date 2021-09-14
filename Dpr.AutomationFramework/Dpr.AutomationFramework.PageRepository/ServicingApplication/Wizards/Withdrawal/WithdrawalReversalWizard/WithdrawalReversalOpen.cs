using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.WithdrawalReversalWizard
{
    public class WithdrawalReversalOpen : GenericWizardOpen
    {

        public WithdrawalReversalOpen()
        {
            pageLoadedElement = clickWithdrawReversal;
            correspondingDataClass = new WithdrawalReversalP1Data().GetType();
            textName = "Withdrawal Reversal Wizard Open";
        }
        public Element clickNewProcess => ribbon.processActionsMenu;
        public Element clickAccountActions => newProcess.accountActions;
        //public Element clickProcessActions => ribbon.processActionsMenu;
        //public Element clickAccountActions2 => processActions.accountActions;
        public Element clickWithdrawReversal => processActions.withdrawalReversal;
    }

    public class WithdrawalReversalOpenData : GenericWizardOpenData
    {
    }
}
