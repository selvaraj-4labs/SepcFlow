using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountMaintenance
{
    public class AccountMaintenanceOpen : GenericWizardOpen
    {
        public AccountMaintenanceOpen()
        {
            pageLoadedElement = clickAccountMaintenance;
            correspondingDataClass = new AccountMaintenanceOpenData().GetType();
            textName = "Account Maintenance Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountAdmin;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountAdmin;
        public Element clickAccountMaintenance => processActions.accountMaintenance;
    }

    public class AccountMaintenanceOpenData : GenericWizardOpenData
    {

    }
}
