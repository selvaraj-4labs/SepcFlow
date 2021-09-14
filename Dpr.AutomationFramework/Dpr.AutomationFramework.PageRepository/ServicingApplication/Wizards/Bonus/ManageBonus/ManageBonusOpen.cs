using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class ManageBonusOpen : GenericWizardOpen
    {

        public ManageBonusOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new ManageBonusOpenData().GetType();
            textName = "Ad Hoc Deposit Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountActions;
        public Element clickAdHocDeposit => processActions.manageBonus;
    }

    public class ManageBonusOpenData : GenericWizardOpenData
    {
    }

}
