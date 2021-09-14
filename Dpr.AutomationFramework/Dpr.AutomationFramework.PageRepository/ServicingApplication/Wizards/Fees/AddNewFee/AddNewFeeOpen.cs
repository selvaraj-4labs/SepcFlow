using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Deposit.AdHocDeposit
{
    public class AddNewFeeOpen : GenericWizardOpen
    {

        public AddNewFeeOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new AddNewFeeOpenData().GetType();
            textName = "Add New Fee Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountActions;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountAdmin;
        public Element clickAdHocDeposit => processActions.addNewFee;
    }

    public class AddNewFeeOpenData : GenericWizardOpenData
    {
    }

}
