using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.CancelOverrideCustomerTaxStatus
{
    public class CancelOverrideCustomerTaxStatusClose : GenericWizardClose
    {
        public CancelOverrideCustomerTaxStatusClose()
        {
            correspondingDataClass = new CancelOverrideCustomerTaxStatusCloseData().GetType();
            textName = "Cancel Override Customer Tax Status Close";
        }
    }

    public class CancelOverrideCustomerTaxStatusCloseData : GenericWizardCloseData
    {
    }
}
