using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUncease
{
    public class BankAccountUnceaseOpen : GenericWizardOpen
    {
        public BankAccountUnceaseOpen()
        {
            pageLoadedElement = clickBankAccountUncease;
            correspondingDataClass = new BankAccountUnceaseOpenData().GetType();
            textName = "Bank Account Unease Open";
        }
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.repayments;
        public Element clickBankAccountUncease => processActions.bankAccountUncease;
    }
    public class BankAccountUnceaseOpenData : GenericWizardOpenData
    {
    }
}
