using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AddRegularDepositClose : GenericWizardClose
    {
        public AddRegularDepositClose()
        {
            correspondingDataClass = new AddRegularDepositCloseData().GetType();
            textName = "Ad Hoc Deposit Close";
        }
    }

    public class AddRegularDepositCloseData : GenericWizardCloseData
    {
    }
}
