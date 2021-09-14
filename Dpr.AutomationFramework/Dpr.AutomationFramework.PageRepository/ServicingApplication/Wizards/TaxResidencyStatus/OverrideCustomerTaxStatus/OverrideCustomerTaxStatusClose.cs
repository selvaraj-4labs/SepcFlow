using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Account.AccountReview
{
    public class OverrideCustomerTaxStatusClose : GenericWizardClose
    {
        public OverrideCustomerTaxStatusClose()
        {
            correspondingDataClass = new OverrideCustomerTaxStatusCloseData().GetType();
            textName = "Override Customer Tax Status Close";
        }
    }

    public class OverrideCustomerTaxStatusCloseData : GenericWizardCloseData
    {
    }
}
