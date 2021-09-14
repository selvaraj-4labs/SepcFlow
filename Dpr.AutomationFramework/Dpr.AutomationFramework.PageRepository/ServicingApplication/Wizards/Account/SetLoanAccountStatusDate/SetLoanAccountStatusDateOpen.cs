using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.SetLoanAccountStatusDate
{
    public class SetLoanAccountStatusDateOpen : GenericWizardOpen
    {
        public SetLoanAccountStatusDateOpen()
        {
            pageLoadedElement = clickSetLoanAccountStatusDate;
            correspondingDataClass = new SetLoanAccountStatusDateOpen().GetType();
            textName = "Set Loan Account Status Date Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountAdmin;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountAdmin;
        public Element clickSetLoanAccountStatusDate => processActions.setLoanAccountStatusDate;
    }

    public class SetLoanAccountStatusDateOpenData : GenericWizardOpenData
    {
    }
}
