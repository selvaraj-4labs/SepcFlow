using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AccountSettingsClose : GenericWizardClose
    {
        public AccountSettingsClose()
        {
            correspondingDataClass = new AccountSettingsCloseData().GetType();
            textName = "Account Settings Close";
        }
    }

    public class AccountSettingsCloseData : GenericWizardCloseData
    {
    }
}
