using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateOverrideCustomerTaxStatus
{
    public class UpdateOverrideCustomerTaxStatusP2 : GenericFinalWizardPage
    {
        public UpdateOverrideCustomerTaxStatusP2()
        {
            correspondingDataClass = new UpdateOverrideCustomerTaxStatusP2Data().GetType();
            textName = "Update Override Customer Tax Status Page 2";
        }
    }

    public class UpdateOverrideCustomerTaxStatusP2Data : GenericFinalWizardPageData
    {
    }
}
