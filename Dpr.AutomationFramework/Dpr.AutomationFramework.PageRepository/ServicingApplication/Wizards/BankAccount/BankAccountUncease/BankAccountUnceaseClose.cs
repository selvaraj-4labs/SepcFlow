using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUncease
{
    public class BankAccountUnceaseClose : GenericWizardClose
    {
        public BankAccountUnceaseClose()
        {
            correspondingDataClass = new BankAccountUnceaseCloseData().GetType();
            textName = "Bank Account Uncease Close";
        }
    }
    public class BankAccountUnceaseCloseData : GenericWizardCloseData
    {
    }
}
