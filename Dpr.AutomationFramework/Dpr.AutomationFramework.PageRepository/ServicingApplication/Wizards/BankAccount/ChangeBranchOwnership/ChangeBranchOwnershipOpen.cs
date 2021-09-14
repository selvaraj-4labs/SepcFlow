using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.ChangeBranchOwnership
{
    public class ChangeBranchOwnershipOpen : GenericWizardOpen
    {
        public ChangeBranchOwnershipOpen()
        {
            pageLoadedElement = clickChangeBranchOwnership;
            correspondingDataClass = new ChangeBranchOwnershipOpenData().GetType();
            textName = "Bank Account Unease Open";
        }
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.repayments;
        public Element clickChangeBranchOwnership => processActions.changeBranchOwnership;
    }
    public class ChangeBranchOwnershipOpenData : GenericWizardOpenData
    {
    }
}
