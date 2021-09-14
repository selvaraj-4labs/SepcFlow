using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.OverrideCustomerTaxStatus
{
    public class OverrideCustomerTaxStatusP3 : GenericFinalWizardPage
    {
        public OverrideCustomerTaxStatusP3()
        {
            correspondingDataClass = new OverrideCustomerTaxStatusP3Data().GetType();
            textName = "Override Customer Tax Status Page 3";
        }
    }

    public class OverrideCustomerTaxStatusP3Data : GenericFinalWizardPageData
    {
    }
}
