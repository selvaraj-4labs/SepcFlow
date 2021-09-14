using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.TaxResidencyStatus.UpdateTaxStatusUpdateRequest
{
    public class UpdateTaxStatusUpdateRequestP2 : GenericFinalWizardPage
    {
        public UpdateTaxStatusUpdateRequestP2()
        {
            correspondingDataClass = new UpdateTaxStatusUpdateRequestP2Data().GetType();
            textName = "Update Tax Status Update Request Page 2";
        }
    }

    public class UpdateTaxStatusUpdateRequestP2Data : GenericFinalWizardPageData
    {
    }
}
