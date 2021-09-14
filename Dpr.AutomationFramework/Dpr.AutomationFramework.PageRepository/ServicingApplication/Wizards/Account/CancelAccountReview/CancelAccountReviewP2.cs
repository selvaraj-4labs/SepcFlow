using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.CancelAccountReview
{
    public class CancelAccountReviewP2 : GenericFinalWizardPage
    {
        public CancelAccountReviewP2()
        {
            correspondingDataClass = new CancelAccountReviewP2Data().GetType();
            textName = "Cancel Account Review Page 2";
        }
    }

    public class CancelAccountReviewP2Data : GenericFinalWizardPageData
    {
    }
}
