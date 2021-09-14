using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.AdHocWithdrawal
{
    public class AdHocWithdrawalClose : GenericWizardClose
    {
        public AdHocWithdrawalClose()
        {
            correspondingDataClass = new AdHocWithdrawalCloseData().GetType();
            textName = "Ad Hoc Withdrawal Close";
        }
    }

    public class AdHocWithdrawalCloseData : GenericWizardCloseData
    {
    }
}
