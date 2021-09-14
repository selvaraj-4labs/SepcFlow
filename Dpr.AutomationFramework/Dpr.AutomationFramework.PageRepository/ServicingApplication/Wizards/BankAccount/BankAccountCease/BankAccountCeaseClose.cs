using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountCease
{
    public class BankAccountCeaseClose : GenericWizardClose
    {
        public BankAccountCeaseClose()
        {
            correspondingDataClass = new BankAccountCeaseCloseData().GetType();
            textName = "Bank Account Cease Close";
        }
    }
    public class BankAccountCeaseCloseData : GenericWizardCloseData
    {
    }
}
