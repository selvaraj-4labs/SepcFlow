using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AdHocDepositOpen : GenericWizardOpen
    {

        public AdHocDepositOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new AdHocDepositOpenData().GetType();
            textName = "Ad Hoc Deposit Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountActions;
        public Element clickAdHocDeposit => processActions.adHocDeposit;
    }

    public class AdHocDepositOpenData : GenericWizardOpenData
    {
        public string productType { get; set; } = null;
    }

}
