using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.CancelRegularDeposit
{
    public class CancelRegularDepositClose : GenericWizardClose
    {
        public CancelRegularDepositClose()
        {
            correspondingDataClass = new CancelRegularDepositCloseData().GetType();
            textName = "Cancel Regular Deposit Close";
        }
    }

    public class CancelRegularDepositCloseData : GenericWizardCloseData
    {
    }
}
