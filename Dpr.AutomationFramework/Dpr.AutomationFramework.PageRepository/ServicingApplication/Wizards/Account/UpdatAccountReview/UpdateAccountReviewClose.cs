using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.UpdateAccountReview
{
    public class UpdateAccountReviewClose : GenericWizardClose
    {
        public UpdateAccountReviewClose()
        {
            correspondingDataClass = new UpdateAccountReviewCloseData().GetType();
            textName = "Account Review Close";
        }
    }

    public class UpdateAccountReviewCloseData : GenericWizardCloseData
    {
    }
}
