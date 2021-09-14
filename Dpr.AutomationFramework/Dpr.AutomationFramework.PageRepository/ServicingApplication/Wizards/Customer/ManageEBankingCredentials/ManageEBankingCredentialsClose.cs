using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class ManageEBankingCredentialsClose : GenericWizardClose
    {
        public ManageEBankingCredentialsClose()
        {
            correspondingDataClass = new ManageEBankingCredentialsCloseData().GetType();
            textName = "Manage EBanking Credentials Close";
        }
    }

    public class ManageEBankingCredentialsCloseData : GenericWizardCloseData
    {
    }
}
