using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AccountSettingsOpen : GenericWizardOpen
    {

        public AccountSettingsOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new AccountSettingsOpenData().GetType();
            textName = "Ad Hoc Deposit Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountAdmin;
        public Element clickAdHocDeposit => processActions.accountSettings;
    }

    public class AccountSettingsOpenData : GenericWizardOpenData
    {
    }

}
