using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.LongTermCare.UpdateConfirmCustomerInLongTermCare
{
    public class UpdateConfirmCustomerInLongTermCareClose : GenericWizardClose
    {
        public UpdateConfirmCustomerInLongTermCareClose()
        {
            correspondingDataClass = new UpdateConfirmCustomerInLongTermCareCloseData().GetType();
            textName = "Update Confirm Customer In Long Term Care  Close";
        }
    }
    public class UpdateConfirmCustomerInLongTermCareCloseData : GenericWizardCloseData
    {
    }
}
