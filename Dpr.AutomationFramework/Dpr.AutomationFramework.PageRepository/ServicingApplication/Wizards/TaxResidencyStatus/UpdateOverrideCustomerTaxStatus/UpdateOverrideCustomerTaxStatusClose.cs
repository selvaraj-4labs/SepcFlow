using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class UpdateOverrideCustomerTaxStatusClose : GenericWizardClose
    {
        public UpdateOverrideCustomerTaxStatusClose()
        {
            correspondingDataClass = new UpdateOverrideCustomerTaxStatusCloseData().GetType();
            textName = "Update Override Customer Tax Status Close";
        }
    }

    public class UpdateOverrideCustomerTaxStatusCloseData : GenericWizardCloseData
    {
    }
}
