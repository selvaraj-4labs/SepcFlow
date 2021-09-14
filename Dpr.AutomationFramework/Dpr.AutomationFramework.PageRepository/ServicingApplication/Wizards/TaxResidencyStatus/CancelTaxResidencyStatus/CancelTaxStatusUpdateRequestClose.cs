using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class CancelTaxStatusUpdateRequestClose : GenericWizardClose
    {
        public CancelTaxStatusUpdateRequestClose()
        {
            correspondingDataClass = new CancelTaxStatusUpdateRequestCloseData().GetType();
            textName = "Cancel Tax Residency Status Close";
        }
    }

    public class CancelTaxStatusUpdateRequestCloseData : GenericWizardCloseData
    {
    }
}
