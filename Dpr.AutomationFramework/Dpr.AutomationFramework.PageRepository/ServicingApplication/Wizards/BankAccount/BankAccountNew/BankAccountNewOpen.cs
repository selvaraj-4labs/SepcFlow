using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountNew
{
    public class BankAccountNewOpen : GenericWizardOpen
    {
        public BankAccountNewOpen()
        {
            pageLoadedElement = clickBankAccountUpdate;
            correspondingDataClass = new BankAccountNewOpenData().GetType();
            textName = "Bank Account New Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.repayments;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.repayments;
        public Element clickBankAccountUpdate => processActions.bankAccountNew;
    }

    public class BankAccountNewOpenData : GenericWizardOpenData
    {
    }
}
