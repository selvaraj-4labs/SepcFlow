using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.ChangeBranchOwnership
{
    public class ChangeBranchOwnershipClose : GenericWizardClose
    {
        public ChangeBranchOwnershipClose()
        {
            correspondingDataClass = new ChangeBranchOwnershipCloseData().GetType();
            textName = "Bank Account Uncease Close";
        }
    }
    public class ChangeBranchOwnershipCloseData : GenericWizardCloseData
    {
    }
}
