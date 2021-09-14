using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountCease
{
    public class BankAccountCeaseOpen : GenericWizardOpen
    {
        public BankAccountCeaseOpen()
        {
            pageLoadedElement = clickBankAccountCease;
            correspondingDataClass = new BankAccountCeaseOpenData().GetType();
            textName = "Bank Account Cease Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.repayments;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.repayments;
        public Element clickBankAccountCease => processActions.bankAccountCease;
    }
    public class BankAccountCeaseOpenData : GenericWizardOpenData
    {
    }
}
