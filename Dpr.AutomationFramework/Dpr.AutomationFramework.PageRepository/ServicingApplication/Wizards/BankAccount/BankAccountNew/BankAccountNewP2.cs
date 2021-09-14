using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountNew
{
    public class BankAccountNewP2 : GenericFinalWizardPage
    {
        public BankAccountNewP2()
        {
            correspondingDataClass = new BankAccountNewP1Data().GetType();
            textName = "Bank Account New Page 2";
        }
    }

    public class BankAccountNewP2Data : GenericFinalWizardPageData
    {
    }

}
