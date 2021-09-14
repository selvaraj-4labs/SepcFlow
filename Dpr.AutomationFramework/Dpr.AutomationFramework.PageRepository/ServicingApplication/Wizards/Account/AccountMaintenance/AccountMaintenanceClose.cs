using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountMaintenance
{
    public class AccountMaintenanceClose : GenericWizardClose
    {
        public AccountMaintenanceClose()
        {
            correspondingDataClass = new AccountMaintenanceCloseData().GetType();
            textName = "Account Review Close";
        }
    }
    public class AccountMaintenanceCloseData : GenericWizardCloseData
    {
    }
}
