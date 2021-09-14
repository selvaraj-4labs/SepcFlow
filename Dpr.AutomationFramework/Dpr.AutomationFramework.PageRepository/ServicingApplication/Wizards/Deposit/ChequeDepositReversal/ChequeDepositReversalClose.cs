using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.ChequeDepositReversal
{
    public class ChequeDepositReversalClose : GenericWizardClose
    {
        public ChequeDepositReversalClose()
        {
            correspondingDataClass = new ChequeDepositReversalCloseData().GetType();
            textName = "Cheque Deposit Reversal Close";
        }
    }
    public class ChequeDepositReversalCloseData : GenericWizardCloseData
    {
    }
}
