using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateTaxResidencyStatus
{
    public class UpdateTaxResidencyStatusP3 : GenericFinalWizardPage
    {
        public UpdateTaxResidencyStatusP3()
        {
            correspondingDataClass = new UpdateTaxResidencyStatusP3Data().GetType();
            textName = "Update Tax/Residency Status Page 2";
        }
    }

    public class UpdateTaxResidencyStatusP3Data : GenericFinalWizardPageData
    {
    }
}
