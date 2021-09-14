using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUpdate
{
    public class BankAccountUpdateClose : GenericWizardClose
    {
        public BankAccountUpdateClose()
        {
            correspondingDataClass = new BankAccountUpdateCloseData().GetType();
            textName = "Bank Account Update Close";
        }
    }
    public class BankAccountUpdateCloseData : GenericWizardCloseData
    {
    }
}
