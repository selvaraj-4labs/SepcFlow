using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.ChequeDepositReversal
{
    public class ChequeDepositReversalOpen : GenericWizardOpen
    {
        public ChequeDepositReversalOpen()
        {
            pageLoadedElement = clickCancelRegularDeposit;
            correspondingDataClass = new ChequeDepositReversalOpenData().GetType();
            textName = "Cheque Deposit Reversal Open";
        }
        //public Element clickNewProcess => ribbon.newProcessMenu;
        //public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountActions;
        public Element clickCancelRegularDeposit => processActions.chequeDepositReversal;
    }
    public class ChequeDepositReversalOpenData : GenericWizardOpenData
    {
    }
}
