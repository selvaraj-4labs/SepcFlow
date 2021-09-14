using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.Fees.UpdateReverseFee
{
    public class UpdateReverseFeeP3 : GenericFinalWizardPage
    {
        public UpdateReverseFeeP3()
        { 
            correspondingDataClass = new UpdateReverseFeeP3Data().GetType();
            textName = "Update Reverse Fee Page 3";
        }
    }

    public class UpdateReverseFeeP3Data : GenericFinalWizardPageData
    { 
    }
}
