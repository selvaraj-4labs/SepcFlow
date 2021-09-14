using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountMaintenance
{
    public class AccountMaintenanceP2 : GenericFinalWizardPage
    {
        public AccountMaintenanceP2()
        {
            correspondingDataClass = new AccountMaintenanceP2Data().GetType();
            textName = "Account Maintenance Page 2";
        }
    }
    public class AccountMaintenanceP2Data : GenericFinalWizardPageData
    {
    }

}
