using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountNew
{
    public class BankAccountNewClose : GenericWizardClose
    {
        public BankAccountNewClose()
        {
            correspondingDataClass = new BankAccountNewCloseData().GetType();
            textName = "Bank Account New Close";
        }
    }

    public class BankAccountNewCloseData : GenericWizardCloseData
    {
    }
}
