using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.CancelAccountReview
{
    public class CancelAccountReviewClose : GenericWizardClose
    {
        public CancelAccountReviewClose()
        {
            correspondingDataClass = new CancelAccountReviewCloseData().GetType();
            textName = "Account Review Close";
        }
    }

    public class CancelAccountReviewCloseData : GenericWizardCloseData
    {
    }
}
