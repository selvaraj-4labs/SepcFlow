using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class UpdateTaxResidencyStatusClose : GenericWizardClose
    {
        public UpdateTaxResidencyStatusClose()
        {
            correspondingDataClass = new UpdateTaxResidencyStatusCloseData().GetType();
            textName = "Update Tax Residency Status Close";
        }
    }

    public class UpdateTaxResidencyStatusCloseData : GenericWizardCloseData
    {
    }
}
