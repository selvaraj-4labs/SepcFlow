using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CancelWithdrawal
{
    public class CancelWithdrawalClose : GenericWizardClose
    {
        public CancelWithdrawalClose()
        {
            correspondingDataClass = new CancelWithdrawalCloseData().GetType();
            textName = "Cancel Withdrawal Close";
        }
    }

    public class CancelWithdrawalCloseData : GenericWizardCloseData
    {
    }
}
