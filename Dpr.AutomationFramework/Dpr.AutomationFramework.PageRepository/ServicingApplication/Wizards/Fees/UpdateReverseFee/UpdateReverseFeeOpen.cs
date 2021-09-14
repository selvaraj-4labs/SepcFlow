using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class UpdateReverseFeeOpen : GenericWizardOpen
    {

        public UpdateReverseFeeOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new UpdateReverseFeeOpenData().GetType();
            textName = "Update Reverse Fee Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountAdmin;
        public Element clickAdHocDeposit => processActions.updateReverseFee;
    }

    public class UpdateReverseFeeOpenData : GenericWizardOpenData
    {
    }

}
