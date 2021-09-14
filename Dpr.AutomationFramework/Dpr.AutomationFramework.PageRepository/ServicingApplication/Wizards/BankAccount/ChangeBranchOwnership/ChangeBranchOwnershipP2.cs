using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.ChangeBranchOwnership
{
    public class ChangeBranchOwnershipP2 : GenericFinalWizardPage
    {
        public ChangeBranchOwnershipP2()
        {
            correspondingDataClass = new ChangeBranchOwnershipP2Data().GetType();
            textName = "Change Branch Ownership Page 2";
        }
    }
    public class ChangeBranchOwnershipP2Data : GenericFinalWizardPageData
    {
    }
}
