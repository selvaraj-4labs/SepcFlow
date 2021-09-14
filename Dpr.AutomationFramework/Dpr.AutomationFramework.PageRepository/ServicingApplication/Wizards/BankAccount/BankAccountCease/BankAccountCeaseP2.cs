using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountCease
{
    public class BankAccountCeaseP2 : GenericFinalWizardPage
    {
        public BankAccountCeaseP2()
        {
            correspondingDataClass = new BankAccountCeaseP2Data().GetType();
            textName = "Bank Account Cease Page 2";
        }
    }

    public class BankAccountCeaseP2Data : GenericFinalWizardPageData
    {
    }
}
