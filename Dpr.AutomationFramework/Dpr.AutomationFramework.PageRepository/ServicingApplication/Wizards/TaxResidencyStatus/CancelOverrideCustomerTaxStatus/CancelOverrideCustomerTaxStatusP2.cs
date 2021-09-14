using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.CancelOverrideCustomerTaxStatus
{
    public class CancelOverrideCustomerTaxStatusP2 : GenericFinalWizardPage
    {
        public CancelOverrideCustomerTaxStatusP2()
        {
            correspondingDataClass = new CancelOverrideCustomerTaxStatusP2Data().GetType();
            textName = "Cancel Override Customer Tax Status Page 2";
        }
    }

    public class CancelOverrideCustomerTaxStatusP2Data : GenericFinalWizardPageData
    {
    }
}
