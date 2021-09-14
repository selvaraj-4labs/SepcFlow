using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class UpdateTaxStatusUpdateRequestClose : GenericWizardClose
    {
        public UpdateTaxStatusUpdateRequestClose()
        {
            correspondingDataClass = new UpdateTaxStatusUpdateRequestCloseData().GetType();
            textName = "Update Tax Status Update Request Close";
        }
    }

    public class UpdateTaxStatusUpdateRequestCloseData : GenericWizardCloseData
    {
    }
}
