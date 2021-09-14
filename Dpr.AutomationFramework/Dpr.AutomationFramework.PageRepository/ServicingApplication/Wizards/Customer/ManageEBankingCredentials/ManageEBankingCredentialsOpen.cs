using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class ManageEBankingCredentialsOpen : GenericWizardOpen
    {
        public ManageEBankingCredentialsOpen()
        {
            pageLoadedElement = clickNewProcess;
            correspondingDataClass = new ManageEBankingCredentialsOpenData().GetType();
            textName = "Manage EBanking Credentials Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.customer;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.customer;
        public Element clickWizard => processActions.manageeBankingCredentials;
    }

    public class ManageEBankingCredentialsOpenData : GenericWizardOpenData
    {
    }
}
