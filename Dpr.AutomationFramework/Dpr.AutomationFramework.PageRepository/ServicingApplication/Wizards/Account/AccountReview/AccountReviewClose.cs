using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class AccountReviewClose : GenericWizardClose
    {
        public AccountReviewClose()
        {
            correspondingDataClass = new AccountReviewCloseData().GetType();
            textName = "Account Review Close";
        }
    }

    public class AccountReviewCloseData : GenericWizardCloseData
    {
    }
}
