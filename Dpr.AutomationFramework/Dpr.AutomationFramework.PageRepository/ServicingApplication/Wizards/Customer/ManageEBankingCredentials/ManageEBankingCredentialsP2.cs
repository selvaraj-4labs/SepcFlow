using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Customer.ManageEBankingCredentials
{
    public class ManageEBankingCredentialsP2 : GenericFinalWizardPage
    {
        public ManageEBankingCredentialsP2()
        {
            correspondingDataClass = new ManageEBankingCredentialsP2Data().GetType();
            textName = "Manage EBanking Credentials Page 2";
        }
    }

    public class ManageEBankingCredentialsP2Data : GenericFinalWizardPageData
    {
    }
}
