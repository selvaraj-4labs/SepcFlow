using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.UpdateAccountReview
{
    public class UpdateAccountReviewP2 : GenericFinalWizardPage
    {
        public UpdateAccountReviewP2()
        {
            correspondingDataClass = new UpdateAccountReviewP2Data().GetType();
            textName = "Update Account Review Page 2";

        }
    }
    public class UpdateAccountReviewP2Data : GenericFinalWizardPageData
    {
    }
}
