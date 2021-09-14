using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUpdate
{
    public class BankAccountUpdateP2 : GenericFinalWizardPage
    {
        public BankAccountUpdateP2()
        {
            correspondingDataClass = new BankAccountUpdateP2Data().GetType();
            textName = "Bank Account Update Page 2";
        }
    }

    public class BankAccountUpdateP2Data : GenericFinalWizardPageData
    { 
    }
}
