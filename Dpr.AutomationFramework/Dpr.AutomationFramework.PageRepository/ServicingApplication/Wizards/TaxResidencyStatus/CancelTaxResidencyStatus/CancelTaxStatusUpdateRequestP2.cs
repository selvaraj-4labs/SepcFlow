using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.CancelTaxResidencyStatus
{
    public class CancelTaxStatusUpdateRequestP2 : GenericFinalWizardPage
    {
        public CancelTaxStatusUpdateRequestP2()
        {
            correspondingDataClass = new CancelTaxResidencyStatusP2Data().GetType();
            textName = "Cancel Tax Residency Status Page 2";
        }
    }

    public class CancelTaxResidencyStatusP2Data : GenericFinalWizardPageData
    {
    }
}
