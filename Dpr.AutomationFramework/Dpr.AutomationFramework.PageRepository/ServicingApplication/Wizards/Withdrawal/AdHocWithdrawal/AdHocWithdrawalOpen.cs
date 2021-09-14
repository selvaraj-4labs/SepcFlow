using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Withdrawal.AdHocWithdrawal
{
    public class AdHocWithdrawalOpen : GenericWizardOpen
    {
        public AdHocWithdrawalOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new AdHocWithdrawalOpenData().GetType();
            textName = "Ad Hoc Withdrawal Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountActions;
        public Element clickModifyAccountTags => processActions.adHocWithdrawal;
    }

    public class AdHocWithdrawalOpenData : GenericWizardOpenData
    {
    }
}
