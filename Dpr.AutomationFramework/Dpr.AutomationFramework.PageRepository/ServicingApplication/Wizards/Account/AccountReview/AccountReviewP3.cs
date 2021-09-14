using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class AccountReviewP3 : GenericFinalWizardPage
    {
        public AccountReviewP3()
        {
            correspondingDataClass = new AccountReviewP3Data().GetType();
            textName = "Account Review Page 3";
        }
    }

    public class AccountReviewP3Data : GenericFinalWizardPageData
    {
    }
}
