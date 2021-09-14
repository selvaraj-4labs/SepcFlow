using Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.GenericPages;

namespace Dpr.AutomationFramework.Dpr.AutomationFramework.PageRepository.ServicingApplication.Wizards.CustomerDeceased.UpdateConfirmCustomerDeceased
{
    public class UpdateConfirmCustomerDeceasedClose : GenericWizardClose
    {
        public UpdateConfirmCustomerDeceasedClose()
        {
            correspondingDataClass = new UpdateConfirmCustomerDeceasedCloseData().GetType();
            textName = "Update Confirm Customer Deceased Close";
        }
    }
    public class UpdateConfirmCustomerDeceasedCloseData : GenericWizardCloseData
    {
    }
}
