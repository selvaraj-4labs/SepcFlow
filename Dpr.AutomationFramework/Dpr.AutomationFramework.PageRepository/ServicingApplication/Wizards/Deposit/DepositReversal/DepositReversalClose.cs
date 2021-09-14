using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.DepositReversal
{
    public class DepositReversalClose : GenericWizardClose
    {
        public DepositReversalClose()
        {
            correspondingDataClass = new DepositReversalCloseData().GetType();
            textName = "Deposit Reversal Close";
        }
    }

    public class DepositReversalCloseData : GenericWizardCloseData
    {
    }
}
