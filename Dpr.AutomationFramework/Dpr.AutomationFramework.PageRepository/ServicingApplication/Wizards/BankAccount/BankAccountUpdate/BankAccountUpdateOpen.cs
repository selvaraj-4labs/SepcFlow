using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.BankAccount.BankAccountUpdate
{
    public class BankAccountUpdateOpen : GenericWizardOpen
    {
        public BankAccountUpdateOpen()
        {
            pageLoadedElement = clickBankAccountUpdate;
            correspondingDataClass = new BankAccountUpdateOpenData().GetType();
            textName = "Bank Account Update Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.repayments;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.repayments;
        public Element clickBankAccountUpdate => processActions.bankAccountUpdate;
    }
    public class BankAccountUpdateOpenData : GenericWizardOpenData
    {
    }
}
