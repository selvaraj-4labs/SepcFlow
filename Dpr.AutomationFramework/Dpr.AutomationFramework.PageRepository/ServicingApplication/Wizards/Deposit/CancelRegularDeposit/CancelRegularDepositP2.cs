using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.CancelRegularDeposit
{
    public class CancelRegularDepositP2 : GenericFinalWizardPage
    {
        public CancelRegularDepositP2()
        {
            correspondingDataClass = new CancelRegularDepositP2Data().GetType();
            textName = "Cancel Regular Deposit Page 2";
        }
    }

    public class CancelRegularDepositP2Data : GenericFinalWizardPageData
    {
    }
}
