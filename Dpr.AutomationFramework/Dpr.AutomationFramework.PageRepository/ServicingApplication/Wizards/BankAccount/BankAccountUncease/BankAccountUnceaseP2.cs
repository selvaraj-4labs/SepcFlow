using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUncease
{
    public class BankAccountUnceaseP2 : GenericFinalWizardPage
    {
        public BankAccountUnceaseP2()
        {
            correspondingDataClass = new BankAccountUnceaseP2Data().GetType();
            textName = "Bank Account Uncease Page 2";
        }
    }

    public class BankAccountUnceaseP2Data : GenericFinalWizardPageData
    {
    }
}
