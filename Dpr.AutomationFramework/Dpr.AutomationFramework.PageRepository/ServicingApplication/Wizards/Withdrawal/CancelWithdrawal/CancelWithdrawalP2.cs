using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.CancelWithdrawal
{
    public class CancelWithdrawalP2 : GenericFinalWizardPage
    {
        public CancelWithdrawalP2()
        {
            correspondingDataClass = new CancelWithdrawalP2Data().GetType();
            textName = "Cancel Withdrawal Page 2";
        }
    }

    public class CancelWithdrawalP2Data : GenericFinalWizardPageData
    {
    }
}
