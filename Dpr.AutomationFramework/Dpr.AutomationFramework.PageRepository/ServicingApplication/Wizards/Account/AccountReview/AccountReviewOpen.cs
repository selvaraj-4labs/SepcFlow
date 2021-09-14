using Dpr.AutomationFramework.Dpr.AutomationFramework.Core.ClassDefinitions;
using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class AccountReviewOpen : GenericWizardOpen
    {
        public AccountReviewOpen()
        {
            pageLoadedElement = clickAccountReview;
            correspondingDataClass = new AccountReviewOpenData().GetType();
            textName = "Account Review Open";
        }
        public Element clickNewProcess => ribbon.newProcessMenu;
        public Element clickAccountActions => newProcess.accountAdmin;
        public Element clickProcessActions => ribbon.processActionsMenu;
        public Element clickAccountActions2 => processActions.accountAdmin;
        public Element clickAccountReview => processActions.accountReview;
    }

    public class AccountReviewOpenData : GenericWizardOpenData
    {
    }
}
